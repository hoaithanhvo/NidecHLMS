using Domain.Specifications;
using Microsoft.IdentityModel.Tokens;
using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Repositories
{
    public interface IGenericRepository<T, TKey> : ICommandRepository<T, TKey> where T : BaseEntity<TKey>

    {
        /// <summary>
        /// READ OPERATIONS use specification
        /// </summary>
        /// <param name="specification"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>

        Task<List<T>> ToListAsync(ISpecification<T> specification, CancellationToken cancellationToken = default);

        Task<bool> ContainsAsync(ISpecification<T> specification, CancellationToken cancellationToken = default);

        Task<bool> ContainsAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default);

        Task<int> CountAsync(ISpecification<T> specification, CancellationToken cancellationToken = default);

        Task<int> CountAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default);

        Task<T> GetAsync(ISpecification<T> specification, CancellationToken cancellationToken = default);

        Task<bool> CheckIsExistAsync(ISpecification<T> specification, CancellationToken cancellationToken = default);

        Task<T> GetByIdAsync(TKey id, CancellationToken cancellationToken = default);

        Task<List<T>> GetAllAsync(CancellationToken cancellationToken = default);

        /// <summary>
		/// Gets the queryable asynchronous
		/// </summary>
		/// <returns></returns>
        IQueryable<T> GetQueryable();
    }
}
