using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Repositories
{
    public interface IUnitOfWork : IDisposable, IAsyncDisposable
    {
        /// <summary>
        /// Save change all activity
        /// </summary>
        /// <returns></returns>
        Task SaveChangesAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Begin trấnction in activity
        /// </summary>
        /// <returns></returns>
        Task BeginTransaction(CancellationToken cancellationToken = default);

        /// <summary>
        /// Commit change all activity
        /// </summary>
        /// <returns></returns>
        Task CommitTransactionAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Rollback activity when has error
        /// </summary>
        /// <returns></returns>
        Task RollBackTransactionAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Complete activity
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<int> Complete(CancellationToken cancellationToken = default);

        bool HasActiveTransaction {  get; }

        bool IsTransactionOwner { get; }

        /// <summary>
        /// GenericRepository
        /// </summary>
        /// <typeparam name="T">Is Entity, T: BaseEntity</typeparam>
        /// <returns></returns>
        IGenericRepository<T, TKey> GenericRepository<T, TKey>() where T : BaseEntity<TKey>;
    }
}
