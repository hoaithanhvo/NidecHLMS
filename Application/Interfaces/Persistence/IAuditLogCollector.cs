namespace Application.Interfaces.Persistence;

public interface IAuditLogCollector
{
    void Capture(string? userId, string? apiName);

    Task<int> FlushAsync(CancellationToken cancellationToken = default);
}
