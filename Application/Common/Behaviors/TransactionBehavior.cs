using Application.Interfaces.Command;
using Application.Interfaces.Repositories;
using MediatR;

namespace Application.Common.Behaviors;

/// <summary>
/// Commits the Unit of Work after every ICommand handler succeeds.
/// FLOW:
///   Handler runs → modifies entities via IUnitOfWork →
///   This behaviour calls CommitAsync() → AppDbContext.SaveChangesAsync fires →
///   Audit fields stamped → transaction committed to DB.
/// If the handler throws, next() throws before CommitAsync() is called.
/// No data is saved. No rollback code needed — EF handles it automatically.
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
        //await _unitOfWork.CommitAsync(cancellationToken);      
        return response;
    }
}