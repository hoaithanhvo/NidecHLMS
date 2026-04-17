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

        private readonly ConcurrentDictionary<string, object> _repositories = new();

        // Transaction state
        private IDbContextTransaction? _currentTransaction;
        private bool _disposed;

        public UnitOfWork(AppDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        #region transaction state

        public bool HasActiveTransaction => _currentTransaction != null;

        public bool IsTransactionOwner { get; private set; }

        #endregion

        #region repository factory 

        /// <summary>
        /// Returns a cached GenericRepository for the given entity type.
        /// Creates one if it doesn't exist (lazy, thread-safe).
        /// </summary>
        public IGenericRepository<T, TKey> GenericRepository<T, TKey>() where T : BaseEntity<TKey>
        {
            var key = $"{typeof(T).Name}_{typeof(TKey).Name}";

            return (IGenericRepository<T, TKey>)_repositories.GetOrAdd(key, _ =>
                new GenericRepository<T, TKey>(_dbContext));
        }

        #endregion

        #region Persistence 

        public async Task SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            await _dbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task<int> Complete(CancellationToken cancellationToken = default)
        {
            return await _dbContext.SaveChangesAsync(cancellationToken);
        }

        #endregion

        #region transaction management

        /// <summary>
        /// Starts a new transaction.
        /// If a transaction is already active, the caller is marked as NOT the owner
        /// </summary>
        public async Task BeginTransaction(CancellationToken cancellationToken = default)
        {
            if (_currentTransaction != null)
            {
                // Nested call — this caller is NOT the transaction owner
                IsTransactionOwner = false;
                return;
            }

            _currentTransaction = await _dbContext.Database.BeginTransactionAsync(cancellationToken);
            IsTransactionOwner = true;
        }

        /// <summary>
        /// SaveChanges + Commit. Auto-rollback on failure.
        /// </summary>
        public async Task CommitTransactionAsync(CancellationToken cancellationToken = default)
        {
            try
            {
                await _dbContext.SaveChangesAsync(cancellationToken);

                if (_currentTransaction != null)
                    await _currentTransaction.CommitAsync(cancellationToken);
            }
            catch
            {
                await RollBackTransactionAsync(cancellationToken);
                throw;
            }
            finally
            {
                await DisposeTransaction();
            }
        }

        /// <summary>
        /// Rollback current transaction. Only the transaction owner can rollback
        /// — prevents nested handlers from accidentally rolling back parent transaction.
        /// </summary>
        public async Task RollBackTransactionAsync(CancellationToken cancellationToken = default)
        {
            if (_currentTransaction == null || !IsTransactionOwner) return;

            try
            {
                await _currentTransaction.RollbackAsync(cancellationToken);
            }
            finally
            {
                await DisposeTransaction();
            }
        }

        #endregion

        #region dispose

        private async Task DisposeTransaction()
        {
            if (_currentTransaction != null)
            {
                await _currentTransaction.DisposeAsync();
                _currentTransaction = null;
                IsTransactionOwner = false;
            }
        }

        public void Dispose()
        {
            if (_disposed) return;
            _disposed = true;

            _currentTransaction?.Dispose();
            _currentTransaction = null;
            IsTransactionOwner = false;
        }

        public async ValueTask DisposeAsync()
        {
            if (_disposed) return;
            _disposed = true;

            if (_currentTransaction != null)
            {
                await _currentTransaction.DisposeAsync();
                _currentTransaction = null;
                IsTransactionOwner = false;
            }
        }

        #endregion
    }
}
