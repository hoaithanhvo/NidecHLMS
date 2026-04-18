using Application.Interfaces.Repositories;
using Domain.Specifications;
using Microsoft.EntityFrameworkCore;
using NidecSystemShared.Abstracts;
using Persistence.Context;
using Persistence.Specifications;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
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

        public GenericRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        #region READ OPERATIONS (AsNoTracking for performance

        public async Task<T> GetByIdAsync(TKey id, CancellationToken cancellationToken = default)
        {
            return await _dbContext.Set<T>().FindAsync(new object[] { id! }, cancellationToken);
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

        public async Task<bool> CheckIsExistAsync(ISpecification<T> specification, CancellationToken cancellationToken = default)
        {
            return await ApplySpecification(specification).AnyAsync(cancellationToken);
        }

        public IQueryable<T> GetQueryable()
        {
            return _dbContext.Set<T>().AsQueryable();
        }

        #endregion

        #region WRITE OPERATIONS do not save changes here — UnitOfWork handles it

        public async Task<T> CreateAsync(T entity, CancellationToken cancellationToken = default)
        {
            await _dbContext.Set<T>().AddAsync(entity, cancellationToken);
            return entity;
        }

        public Task<T> UpdateAsync(T entity, CancellationToken cancellationToken = default)
        {
            var entry = _dbContext.Entry(entity);
            if (entry.State == EntityState.Detached)
                _dbContext.Set<T>().Attach(entity);
            entry.State = EntityState.Modified;

            // Protect original audit fields from being overwritten
            entry.Property("CreatedDate").IsModified = false;
            entry.Property("CreatedBy").IsModified = false;

            return Task.FromResult(entity);
        }

        /// <summary>
        /// Soft-delete: sets IsDeleted = true + DeleteDate if entity supports it.
        /// Falls back to hard-delete if entity has no IsDeleted property.
        /// </summary>
        public Task<T> DeleteAsync(T entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteHardAsync(T entity, CancellationToken cancellationToken = default)
        {
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

            ChangeStatusImpl(entity, status, listObjectNotChange);

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

            foreach (var entity in entities)
            {
                ChangeStatusImpl(entity, status, listObjectNotChange);
                _dbContext.Entry(entity).State = EntityState.Modified;
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
        /// Recursively traverses entity's navigation properties and sets StatusId on each.
        /// Uses checkedObject to track already-visited entities and prevent infinite loops.
        /// Adapted from Downtime project pattern — no Console.Write, no SaveChanges.
        /// </summary>
        private void ChangeStatusImpl(object entity, int status, List<Dictionary<string, int>> checkedObject)
        {
            // Track this entity to prevent revisiting
            var idProp = entity.GetType().GetProperty("Id");
            if (idProp != null)
            {
                var objectState = new Dictionary<string, int>
                {
                    { entity.GetType().Name, (int)idProp.GetValue(entity)! }
                };

                if (!checkedObject.Any(x =>
                    x.Keys.SequenceEqual(objectState.Keys) &&
                    (x.Values.SequenceEqual(new[] { 0 }) || x.Values.SequenceEqual(objectState.Values))))
                {
                    checkedObject.Add(objectState);
                }
                else
                {
                    return; // Already processed
                }
            }

            foreach (var property in entity.GetType().GetProperties())
            {
                if (property.PropertyType.IsClass &&
                    property.GetValue(entity) != null &&
                    property.PropertyType != typeof(string))
                {
                    // Handle collections (List<>, HashSet<>)
                    if (property.PropertyType.IsGenericType)
                    {
                        var genericType = property.PropertyType.GetGenericTypeDefinition();
                        if (genericType == typeof(List<>) || genericType == typeof(HashSet<>))
                        {
                            var collection = (IEnumerable)property.GetValue(entity)!;
                            foreach (var item in collection)
                            {
                                if (item != null && item.GetType().IsClass)
                                {
                                    ChangeStatusImpl(item, status, checkedObject);
                                }
                            }
                        }
                    }
                    else
                    {
                        // Handle single navigation properties
                        var navValue = property.GetValue(entity)!;
                        var navIdProp = navValue.GetType().GetProperty("Id");
                        if (navIdProp == null) continue;

                        var navId = (int)navIdProp.GetValue(navValue)!;
                        bool alreadyChecked = checkedObject.Any(x =>
                            x.ContainsKey(property.Name) &&
                            (x.Values.Contains(0) || x.Values.Contains(navId)));

                        if (!alreadyChecked)
                        {
                            checkedObject.Add(new Dictionary<string, int>
                            {
                                { property.Name, navId }
                            });
                            ChangeStatusImpl(navValue, status, checkedObject);
                        }
                    }
                }
                else
                {
                    // Set StatusId and UpdatedDate on the entity itself
                    if (property.Name == "StatusId")
                        property.SetValue(entity, status);
                    else if (property.Name == "UpdatedDate")
                        property.SetValue(entity, DateTime.UtcNow);
                }
            }

            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        #endregion
    }
}
