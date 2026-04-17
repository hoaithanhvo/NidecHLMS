using Application.Interfaces.Repositories;
using Domain.Specifications;
using Microsoft.Extensions.Logging;
using NidecSystemShared.Abstracts;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class GenericRepository<T, TKey> : IGenericRepository<T, TKey> where T : BaseEntity<T>
    {
        private readonly AppDbContext _dbContext;
        private ILogger<GenericRepository<T, TKey>> _logger;    
        public GenericRepository(AppDbContext dbContext, ILogger<GenericRepository<T, TKey>> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }
        public Task<bool> ChangeStatusAsync(object entity, int status, CancellationToken cancellationToken = default, List<Dictionary<string, int>>? listObjectNotChange = null)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ChangeStatusAsync(List<object> entities, int status, CancellationToken cancellationToken = default, List<Dictionary<string, int>>? listObjectNotChange = null)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CheckIsExistAsync(ISpecification<T> specification, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ContainsAsync(ISpecification<T> specification, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ContainsAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync(ISpecification<T> specification, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<T> CreateAsync(T entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<T> DeleteAsync(T entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteHardAsync(T entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetAsync(ISpecification<T> specification, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(TKey id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetQueryable()
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> ToListAsync(ISpecification<T> specification, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateAsync(T entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
