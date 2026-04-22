using Application.Interfaces.Command;
using Application.Interfaces.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
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
public class TransactionBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> 
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
		// chỉ apply cho command
		if(request is not ICommand<TResponse>)
			return await next();

		var strategy = _unitOfWork.CreateExecutionStrategy();

		return await strategy.ExecuteAsync(async () =>
		{
			await _unitOfWork.BeginTransaction(cancellationToken);

			try
			{
				var response = await next();

				await _unitOfWork.CommitTransactionAsync(cancellationToken);

				return response;
			}
			catch(Exception ex)
			{
				_logger.LogWarning(ex,
					"Transaction rolling back for {RequestName}",
					typeof(TRequest).Name);

				await _unitOfWork.RollBackTransactionAsync(cancellationToken);
				throw;
			}
		});
	}
}
