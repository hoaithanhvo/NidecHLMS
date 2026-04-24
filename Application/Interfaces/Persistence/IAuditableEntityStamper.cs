namespace Application.Interfaces.Persistence;

public interface IAuditableEntityStamper
{
    void StampAuditableEntities(string userId);
}
