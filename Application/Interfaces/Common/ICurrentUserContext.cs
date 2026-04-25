namespace Application.Interfaces.Common;

public interface ICurrentUserContext
{
    string? UserId { get; }
    string? RequestPath { get; }
    bool IsAuthenticated { get; }
}
