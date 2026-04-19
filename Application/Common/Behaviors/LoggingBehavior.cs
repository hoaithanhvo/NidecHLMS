using MediatR;
using Application.Interfaces.Common;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace Application.Common.Behaviors;

/// <summary>
/// Automatically logs every MediatR request: entry, exit, elapsed time, and errors
/// No handler ever needs to write these logs manually
/// </summary>
public class LoggingBehavior<TRequest, TResponse>
    : IPipelineBehavior<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
{
    private readonly ILogger<LoggingBehavior<TRequest, TResponse>> _logger;
    private readonly ICurrentUserContext _currentUserContext;

    public LoggingBehavior(
        ILogger<LoggingBehavior<TRequest, TResponse>> logger,
        ICurrentUserContext currentUserContext)
    {
        _logger = logger;
        _currentUserContext = currentUserContext;
    }

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        var requestName = typeof(TRequest).Name;
        var stopwatch = Stopwatch.StartNew();
        var userId = _currentUserContext.UserId;

        _logger.LogInformation(
            "Handling {RequestName} (UserId: {UserId})",
            requestName, userId);

        try
        {
            var response = await next();

            stopwatch.Stop();

            _logger.LogInformation(
                "Handled {RequestName} in {ElapsedMilliseconds}ms (UserId: {UserId})",
                requestName, stopwatch.ElapsedMilliseconds, userId);

            return response;
        }
        catch (Exception ex)
        {
            stopwatch.Stop();

            // WARNING only — ExceptionHandlingMiddleware is the authoritative error logger
            // with full HTTP context (method, path, status code, stack trace)
            // Logging the full exception here would create duplicate log entries
            _logger.LogWarning(
                "Request {RequestName} failed after {ElapsedMilliseconds}ms (UserId: {UserId}) — {ErrorType}: {ErrorMessage}",
                requestName, stopwatch.ElapsedMilliseconds, userId, ex.GetType().Name, ex.Message);

            throw; 
        }
    }
}
