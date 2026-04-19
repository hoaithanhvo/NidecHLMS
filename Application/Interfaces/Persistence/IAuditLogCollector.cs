namespace Application.Interfaces.Persistence;

public interface IAuditLogCollector
{
    void Capture(string? userId);

    Task<int> FlushAsync(CancellationToken cancellationToken = default);
}
