using Application.Interfaces.Persistence;
using Application.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using NidecSystemShared.Abstracts;
using Persistence.Context;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    /// <summary>
    /// Unit of Work — scoped lifetime (one per HTTP request).
    /// Lazily creates and caches GenericRepository instances.
    /// Owns transaction lifecycle: Begin → Commit / Rollback.
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _dbContext;
        private readonly IAuditLogCollector _auditLogCollector;
        private readonly ConcurrentDictionary<(Type EntityType, Type KeyType), object> _repositories = new();

        // Transaction state
        private IDbContextTransaction? _currentTransaction;
        private int _transactionDepth;
        private bool _disposed;

        public UnitOfWork(AppDbContext dbContext, IAuditLogCollector auditLogCollector)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            _auditLogCollector = auditLogCollector ?? throw new ArgumentNullException(nameof(auditLogCollector));
        }

        #region transaction state

        public bool HasActiveTransaction => _currentTransaction != null;

        // Owner means this scope is at the outermost transaction layer.
        public bool IsTransactionOwner => _currentTransaction != null && _transactionDepth == 1;

        #endregion

        #region repository factory 

        /// <summary>
        /// Returns a cached GenericRepository for the given entity type
        /// Creates one if it does not exist (lazy, thread-safe)
        /// </summary>
        public IGenericRepository<T, TKey> GenericRepository<T, TKey>() where T : BaseEntity<TKey>
        {
            var key = (typeof(T), typeof(TKey));

            return (IGenericRepository<T, TKey>)_repositories.GetOrAdd(key, _ =>
                new GenericRepository<T, TKey>(_dbContext));
        }

        #endregion

        // No public SaveChangesAsync() or Complete() methods
        // Only CommitTransactionAsync() triggers SaveChanges enforced by TransactionBehavior
        // This prevents handlers from accidentally bypassing the pipeline

        #region transaction management

        /// <summary>
        /// Starts a new transaction scope.
        /// Only the outermost scope opens the physical transaction.
        /// </summary>
        public async Task BeginTransaction(CancellationToken cancellationToken = default)
        {
            if (_disposed)
                throw new ObjectDisposedException(nameof(UnitOfWork));

            if (_currentTransaction == null)
            {
                _currentTransaction = await _dbContext.Database.BeginTransactionAsync(cancellationToken);
            }

            _transactionDepth++;
        }

        /// <summary>
        /// Commits the current transaction scope.
        /// Only the outermost scope executes SaveChanges + Commit.
        /// </summary>
        public async Task CommitTransactionAsync(CancellationToken cancellationToken = default)
        {
            if (_currentTransaction == null || _transactionDepth == 0)
                throw new InvalidOperationException("No active transaction to commit.");

            if (_transactionDepth > 1)
            {
                // Nested scope: only decrement; outermost scope commits.
                _transactionDepth--;
                return;
            }

            try
            {
                // 1) Persist business data first so identity keys are generated.
                await _dbContext.SaveChangesAsync(cancellationToken);

                // 2) Materialize and stage audit rows using final key values.
                var stagedAuditCount = await _auditLogCollector.FlushAsync(cancellationToken);
                if (stagedAuditCount > 0)
                {
                    // 3) Persist audit rows in the same transaction.
                    await _dbContext.SaveChangesAsync(cancellationToken);
                }

                await _currentTransaction.CommitAsync(cancellationToken);
            }
            catch
            {
                await RollBackTransactionAsync(cancellationToken);
                throw;
            }
            finally
            {
                await DisposeTransactionAsync();
            }
        }

        /// <summary>
        /// Rolls back the physical transaction and clears all nested scopes.
        /// </summary>
        public async Task RollBackTransactionAsync(CancellationToken cancellationToken = default)
        {
            if (_currentTransaction == null || _transactionDepth == 0) return;

            try
            {
                await _currentTransaction.RollbackAsync(cancellationToken);
            }
            finally
            {
                _transactionDepth = 0;
                await DisposeTransactionAsync();
            }
        }

        #endregion

        #region dispose

        private async Task DisposeTransactionAsync()
        {
            if (_currentTransaction != null)
            {
                await _currentTransaction.DisposeAsync();
                _currentTransaction = null;
            }

            _transactionDepth = 0;
        }

        public void Dispose()
        {
            if (_disposed) return;
            _disposed = true;
            _repositories.Clear();

            _currentTransaction?.Dispose();
            _currentTransaction = null;
            _transactionDepth = 0;
        }

        public async ValueTask DisposeAsync()
        {
            if (_disposed) return;
            _disposed = true;

            if (_currentTransaction != null)
            {
                await _currentTransaction.DisposeAsync();
                _currentTransaction = null;
            }

            _repositories.Clear();
            _transactionDepth = 0;
        }

        #endregion
    }
}
