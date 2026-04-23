using Application.Interfaces.Repositories;
using Domain.Specifications;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using NidecSystemShared.Abstracts;
using Persistence.Context;
using Persistence.Specifications;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    /// <summary>
    /// Generic repository that provides CRUD operations + specification queries
    /// Read operations use AsNoTracking for performance.
    /// Write operations do NOT call SaveChangesAsync — UnitOfWork handles that
    /// </summary>
    public class GenericRepository<T, TKey> : IGenericRepository<T, TKey> where T : BaseEntity<TKey>
    {
        private readonly AppDbContext _dbContext;
        private static readonly ConcurrentDictionary<Type, EntityGraphMetadata> EntityGraphMetadataCache = new();

        public GenericRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        #region READ OPERATIONS with AsNoTracking for increase performance

        public async Task<T> GetByIdAsync(TKey id, CancellationToken cancellationToken = default)
        {
            var entity = await _dbContext.Set<T>().FindAsync(new object[] { id! }, cancellationToken);
            if (entity != null)
                _dbContext.Entry(entity).State = EntityState.Detached;

            return entity;
        }

        public async Task<T> GetAsync(ISpecification<T> specification, CancellationToken cancellationToken = default)
        {
            return await ApplySpecification(specification)
                .AsNoTracking()
                .FirstOrDefaultAsync(cancellationToken);
        }

        public async Task<List<T>> ToListAsync(ISpecification<T> specification, CancellationToken cancellationToken = default)
        {
            return await ApplySpecification(specification)
                .AsNoTracking()
                .ToListAsync(cancellationToken);
        }

        public async Task<List<T>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await _dbContext.Set<T>()
                .AsNoTracking()
                .ToListAsync(cancellationToken);
        }

        public async Task<int> CountAsync(ISpecification<T> specification, CancellationToken cancellationToken = default)
        {
            return await ApplySpecification(specification).CountAsync(cancellationToken);
        }

        public async Task<int> CountAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default)
        {
            return await _dbContext.Set<T>().CountAsync(predicate, cancellationToken);
        }

        public async Task<bool> ContainsAsync(ISpecification<T> specification, CancellationToken cancellationToken = default)
        {
            return await ApplySpecification(specification).AnyAsync(cancellationToken);
        }

        public async Task<bool> ContainsAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default)
        {
            return await _dbContext.Set<T>().AnyAsync(predicate, cancellationToken);
        }

        #endregion

        #region WRITE OPERATIONS do not save changes here let UnitOfWork handles it

        public async Task<T> CreateAsync(T entity, CancellationToken cancellationToken = default)
        {
            ArgumentNullException.ThrowIfNull(entity);
            await _dbContext.Set<T>().AddAsync(entity, cancellationToken);
            return entity;
        }

        public Task<T> UpdateAsync(T entity, CancellationToken cancellationToken = default)
        {
            ArgumentNullException.ThrowIfNull(entity);

			var entry = _dbContext.Entry(entity);
            if (entry.State == EntityState.Detached)
                _dbContext.Set<T>().Attach(entity);
            entry.State = EntityState.Modified;

            ProtectImmutableAuditFields(entry);

            return Task.FromResult(entity);
        }

        /// <summary>
        /// Hard-delete only.
        /// TODO: Add a dedicated soft-delete strategy when domain scope requires it.
        /// </summary>
        public Task<T> DeleteAsync(T entity, CancellationToken cancellationToken = default)
        {
            ArgumentNullException.ThrowIfNull(entity);

            _dbContext.Set<T>().Remove(entity);
            return Task.FromResult(entity);
        }

        public Task<bool> DeleteHardAsync(T entity, CancellationToken cancellationToken = default)
        {
            ArgumentNullException.ThrowIfNull(entity);
            _dbContext.Set<T>().Remove(entity);
            return Task.FromResult(true);
        }

        /// <summary>
        /// Changes the StatusId on a single entity and recursively Restricts to navigation properties.
        /// </summary>
        public Task<bool> ChangeStatusAsync(
            object entity, int status,
            CancellationToken cancellationToken = default,
            List<Dictionary<string, int>>? listObjectNotChange = null)
        {
            if (entity == null) return Task.FromResult(false);

            listObjectNotChange ??= new List<Dictionary<string, int>>();
            var visitedKeys = BuildVisitedKeys(listObjectNotChange);
            ChangeStatusImpl(entity, status, visitedKeys);

            return Task.FromResult(true);
        }

        /// <summary>
        /// Changes the StatusId on multiple entities and recursively Restricts to navigation properties.
        /// </summary>
        public Task<bool> ChangeStatusAsync(
            List<object> entities, int status,
            CancellationToken cancellationToken = default,
            List<Dictionary<string, int>>? listObjectNotChange = null)
        {
            if (entities == null || entities.Count == 0) return Task.FromResult(false);

            listObjectNotChange ??= new List<Dictionary<string, int>>();
            var visitedKeys = BuildVisitedKeys(listObjectNotChange);

            foreach (var entity in entities)
            {
                ChangeStatusImpl(entity, status, visitedKeys);
            }

            return Task.FromResult(true);
        }

        #endregion

        #region private helpers 

        /// <summary>
        /// Delegates to SpecificationEvaluator to build the query.
        /// </summary>
        private IQueryable<T> ApplySpecification(ISpecification<T> specification)
        {
            return SpecificationEvaluator<T, TKey>.GetQuery(_dbContext.Set<T>().AsQueryable(), specification);
        }

        /// <summary>
        /// Recursively traverses loaded navigation graph and sets StatusId/UpdatedDate when available.
        /// Reflection metadata is cached per type to avoid repeated GetProperties() scans.
        /// </summary>
        private void ChangeStatusImpl(object entity, int status, HashSet<string> visitedKeys)
        {
            var metadata = GetEntityGraphMetadata(entity.GetType());
            var visitedKey = BuildVisitedKey(entity, metadata.IdProperty);

            if (!visitedKeys.Add(visitedKey))
                return;

            ApplyStatusAndUpdatedDate(entity, metadata, status);

            foreach (var referenceNav in metadata.ReferenceNavigations)
            {
                var navValue = referenceNav.GetValue(entity);
                if (navValue == null) continue;
                ChangeStatusImpl(navValue, status, visitedKeys);
            }

            foreach (var collectionNav in metadata.CollectionNavigations)
            {
                if (collectionNav.GetValue(entity) is not IEnumerable collection) continue;

                foreach (var item in collection)
                {
                    if (item == null) continue;
                    ChangeStatusImpl(item, status, visitedKeys);
                }
            }

            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        private static void ProtectImmutableAuditFields(EntityEntry entry)
        {
            if (HasProperty(entry, EntityPropertyNames.CreatedDate))
                entry.Property(EntityPropertyNames.CreatedDate).IsModified = false;
            if (HasProperty(entry, EntityPropertyNames.CreatedBy))
                entry.Property(EntityPropertyNames.CreatedBy).IsModified = false;
            if (HasProperty(entry, EntityPropertyNames.CreatedAt))
                entry.Property(EntityPropertyNames.CreatedAt).IsModified = false;
        }

        private static bool HasProperty(EntityEntry entry, string propertyName)
            => entry.Metadata.FindProperty(propertyName) != null;

        private static HashSet<string> BuildVisitedKeys(List<Dictionary<string, int>> checkedObjects)
        {
            var visitedKeys = new HashSet<string>(StringComparer.Ordinal);

            foreach (var map in checkedObjects)
            {
                foreach (var item in map)
                {
                    visitedKeys.Add($"{item.Key}:{item.Value}");
                }
            }

            return visitedKeys;
        }

        private static EntityGraphMetadata GetEntityGraphMetadata(Type entityType)
        {
            return EntityGraphMetadataCache.GetOrAdd(entityType, type =>
            {
                var allProperties = type.GetProperties(BindingFlags.Instance | BindingFlags.Public);

                return new EntityGraphMetadata(
                    allProperties.FirstOrDefault(x => x.Name == EntityPropertyNames.Id),
                    allProperties.FirstOrDefault(x => x.Name == EntityPropertyNames.StatusId),
                    allProperties.FirstOrDefault(x =>
                        x.Name == EntityPropertyNames.UpdatedDate ||
                        x.Name == EntityPropertyNames.UpdatedAt),
                    allProperties.Where(IsReferenceNavigationProperty).ToArray(),
                    allProperties.Where(IsCollectionNavigationProperty).ToArray());
            });
        }

        private static bool IsReferenceNavigationProperty(PropertyInfo property)
        {
            var propertyType = property.PropertyType;
            return propertyType.IsClass
                   && propertyType != typeof(string)
                   && !typeof(IEnumerable).IsAssignableFrom(propertyType)
                   && propertyType.GetProperty(EntityPropertyNames.Id) != null;
        }

        private static bool IsCollectionNavigationProperty(PropertyInfo property)
        {
            if (property.PropertyType == typeof(string)) return false;
            if (!typeof(IEnumerable).IsAssignableFrom(property.PropertyType)) return false;
            if (!property.PropertyType.IsGenericType) return false;

            var genericType = property.PropertyType.GetGenericArguments().FirstOrDefault();
            return genericType != null
                   && genericType.IsClass
                   && genericType != typeof(string)
                   && genericType.GetProperty(EntityPropertyNames.Id) != null;
        }

        private static string BuildVisitedKey(object entity, PropertyInfo? idProperty)
        {
            var idValue = idProperty?.GetValue(entity)?.ToString();
            return idValue != null
                ? $"{entity.GetType().FullName}:{idValue}"
                : $"{entity.GetType().FullName}:ref:{RuntimeHelpers.GetHashCode(entity)}";
        }

        private static void ApplyStatusAndUpdatedDate(object entity, EntityGraphMetadata metadata, int status)
        {
            if (metadata.StatusProperty?.CanWrite == true)
                metadata.StatusProperty.SetValue(entity, status);

            if (metadata.UpdatedDateProperty?.CanWrite == true)
                metadata.UpdatedDateProperty.SetValue(entity, DateTime.UtcNow);
        }

        private sealed record EntityGraphMetadata(
            PropertyInfo? IdProperty,
            PropertyInfo? StatusProperty,
            PropertyInfo? UpdatedDateProperty,
            PropertyInfo[] ReferenceNavigations,
            PropertyInfo[] CollectionNavigations);

        private sealed class EntityConventionProperties
        {
            public int Id { get; set; }
            public int StatusId { get; set; }
            public DateTime UpdatedDate { get; set; }
            public DateTime UpdatedAt { get; set; }
            public DateTime CreatedDate { get; set; }
            public DateTime CreatedAt { get; set; }
            public string CreatedBy { get; set; } = string.Empty;
        }

        private static class EntityPropertyNames
        {
            public const string Id = nameof(EntityConventionProperties.Id);
            public const string StatusId = nameof(EntityConventionProperties.StatusId);
            public const string UpdatedDate = nameof(EntityConventionProperties.UpdatedDate);
            public const string UpdatedAt = nameof(EntityConventionProperties.UpdatedAt);
            public const string CreatedDate = nameof(EntityConventionProperties.CreatedDate);
            public const string CreatedAt = nameof(EntityConventionProperties.CreatedAt);
            public const string CreatedBy = nameof(EntityConventionProperties.CreatedBy);
        }

        #endregion
    }
}
