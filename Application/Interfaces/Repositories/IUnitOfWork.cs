using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Repositories
{
    /// <summary>
    /// Unit of Work — coordinates transaction lifecycle and repository access.
    /// Scoped lifetime (one per HTTP request).
    /// 
    /// IMPORTANT: Only CommitTransactionAsync triggers SaveChanges.
    /// Handlers should NEVER call save directly — TransactionBehavior handles it.
    /// </summary>
    public interface IUnitOfWork : IDisposable, IAsyncDisposable
    {
        /// <summary>
        /// Begins a new database transaction scope.
        /// Supports nested scopes; only the outermost scope opens the physical transaction.
        /// </summary>
        Task BeginTransaction(CancellationToken cancellationToken = default);

        /// <summary>
        /// Commits the current transaction scope.
        /// Only the outermost scope executes SaveChanges + Commit.
        /// </summary>
        Task CommitTransactionAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Rolls back the current physical transaction and clears all nested scopes.
        /// </summary>
        Task RollBackTransactionAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Whether a database transaction is currently active.
        /// </summary>
        bool HasActiveTransaction { get; }

        /// <summary>
        /// Whether the current scope is the outermost active transaction scope.
        /// </summary>
        bool IsTransactionOwner { get; }

        /// <summary>
        /// Returns a cached GenericRepository for the given entity type.
        /// Creates one lazily if it doesn't exist.
        /// </summary>
        /// <typeparam name="T">Entity type, must extend BaseEntity&lt;TKey&gt;</typeparam>
        /// <typeparam name="TKey">Primary key type</typeparam>
        IGenericRepository<T, TKey> GenericRepository<T, TKey>() where T : BaseEntity<TKey>;
    }
}

