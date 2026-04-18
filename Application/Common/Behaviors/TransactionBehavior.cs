using Application.Interfaces.Command;
using Application.Interfaces.Repositories;
using MediatR;

namespace Application.Common.Behaviors;

/// <summary>
/// Commits the Unit of Work after every ICommand handler succeeds
/// FLOW
///   Handler runs => modifies entities via IUnitOfWork =>
///   This behavior calls CommitTransactionAsync() → AppDbContext.SaveChangesAsync  =>
///   Audit fields stamped → transaction committed to DB.
/// If the handler throws, next() throws before CommitTransactionAsync() is called
/// No data is saved. No rollback code needed — EF handles it automatically
/// </summary>
public class TransactionBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : ICommand<TResponse>
{
    private readonly IUnitOfWork _unitOfWork;

    public TransactionBehavior(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<TResponse> Handle(
        TRequest request,
        RequestHandlerDelegate<TResponse> next,
        CancellationToken cancellationToken)
    {
        //run the handler
        var response = await next();
        //commit only on success
        await _unitOfWork.CommitTransactionAsync(cancellationToken);
        return response;
    }
}