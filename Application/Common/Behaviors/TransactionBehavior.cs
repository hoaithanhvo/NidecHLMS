using Application.Interfaces.Command;
using Application.Interfaces.Repositories;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Common.Behaviors;

/// <summary>
/// Manages the database transaction lifecycle for every ICommand.
/// PIPELINE POSITION: Wraps AuditBehavior (outer)
/// 
/// FLOW:
///   BeginTransaction()
///   next() > AuditBehavior > Handler (entities modified + audit rows added)
///   CommitTransactionAsync() → SaveChanges + Commit (entities + audit in ONE transaction)
///   
/// ON FAILURE:
///   next() throws > RollbackTransaction > nothing is saved > exception propagates to LoggingBehavior
/// </summary>
public class TransactionBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : ICommand<TResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ILogger<TransactionBehavior<TRequest, TResponse>> _logger;

    public TransactionBehavior(IUnitOfWork unitOfWork, ILogger<TransactionBehavior<TRequest, TResponse>> logger)
    {
        _unitOfWork = unitOfWork;
        _logger = logger;
    }

    public async Task<TResponse> Handle(
        TRequest request,
        RequestHandlerDelegate<TResponse> next,
        CancellationToken cancellationToken)
    {
        // Begin transaction if one is already active (nested command), UoW handles 
        await _unitOfWork.BeginTransaction(cancellationToken);

        try
        {
            // Run pipeline: AuditBehavior > Handler
            // After this, ChangeTracker has entity changes + audit log entries — NOT yet saved
            var response = await next();

            // Commit: SaveChanges + Commit (entities + audit logs in one atomic operation)
            await _unitOfWork.CommitTransactionAsync(cancellationToken);

            return response;
        }
        catch (Exception ex)
        {
            _logger.LogWarning(ex, "Transaction rolling back for {RequestName}", typeof(TRequest).Name);
            await _unitOfWork.RollBackTransactionAsync(cancellationToken);
            throw;
        }
    }
}
