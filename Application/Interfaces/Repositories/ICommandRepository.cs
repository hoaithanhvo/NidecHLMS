using NidecSystemShared.Abstracts;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Interfaces.Repositories
{
    /// <summary>
    /// Handles all Write (Command) operations for the entity
    /// Following CQRS and Interface Segregation Principle
    /// </summary>
    public interface ICommandRepository<T, TKey> where T : BaseEntity<TKey>
    {
        Task<T> CreateAsync(T entity, CancellationToken cancellationToken = default);

        Task<T> UpdateAsync(T entity, CancellationToken cancellationToken = default);

        Task<T> DeleteAsync(T entity, CancellationToken cancellationToken = default);

        Task<bool> DeleteHardAsync(T entity, CancellationToken cancellationToken = default);

        Task<bool> ChangeStatusAsync(object entity, int status, CancellationToken cancellationToken = default, 
            List<Dictionary<string, int>>? listObjectNotChange = null);

        Task<bool> ChangeStatusAsync(List<object> entities, int status, CancellationToken cancellationToken = default,
            List<Dictionary<string, int>>? listObjectNotChange = null);
    }
}
