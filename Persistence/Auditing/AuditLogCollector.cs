using Application.Interfaces.Persistence;
using Persistence.Context;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Text.Json;

namespace Persistence.Auditing;

public sealed class AuditLogCollector : IAuditLogCollector
{
    private readonly AppDbContext _dbContext;
    private readonly List<PendingAuditLog> _pending = new();

    public AuditLogCollector(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Capture(string? userId)
    {
        var entries = _dbContext.ChangeTracker.Entries()
            .Where(e => e.Entity is not LOG_AUDIT &&
                        e.State is EntityState.Added or EntityState.Modified or EntityState.Deleted)
            .ToList();

        foreach (var entry in entries)
        {
            var oldValues = new Dictionary<string, object?>();
            var newValues = new Dictionary<string, object?>();

            foreach (var property in entry.Properties)
            {
                if (property.IsTemporary) continue;

                switch (entry.State)
                {
                    case EntityState.Added:
                        newValues[property.Metadata.Name] = property.CurrentValue;
                        break;
                    case EntityState.Deleted:
                        oldValues[property.Metadata.Name] = property.OriginalValue;
                        break;
                    case EntityState.Modified:
                        if (!property.IsModified) continue;
                        oldValues[property.Metadata.Name] = property.OriginalValue;
                        newValues[property.Metadata.Name] = property.CurrentValue;
                        break;
                }
            }

            if (!oldValues.Any() && !newValues.Any())
                continue;

            _pending.Add(new PendingAuditLog
            {
                Entry = entry,
                State = entry.State,
                EntityName = entry.Entity.GetType().Name,
                OldDataJson = oldValues.Any() ? JsonSerializer.Serialize(oldValues) : null,
                NewDataJson = newValues.Any() ? JsonSerializer.Serialize(newValues) : null,
                UserId = userId
            });
        }
    }

    public async Task<int> FlushAsync(CancellationToken cancellationToken = default)
    {
        if (_pending.Count == 0) return 0;

        var actionBy = await ResolveActionByAsync(_pending[0].UserId, cancellationToken);

        var entities = _pending.Select(x => new LOG_AUDIT
        {
            EntityName = x.EntityName,
            RecordId = ResolveRecordId(x),
            Action = x.State.ToString(),
            ActionBy = actionBy,
            OldData = x.OldDataJson,
            NewData = x.NewDataJson
        }).ToList();

        ApplyBaseAuditFields(entities, _pending, actionBy);
        await _dbContext.Set<LOG_AUDIT>().AddRangeAsync(entities, cancellationToken);
        _pending.Clear();
        return entities.Count;
    }

    private static int ResolveRecordId(PendingAuditLog pending)
    {
        var primaryKeyName = pending.Entry.Metadata.FindPrimaryKey()?.Properties
            .Select(x => x.Name)
            .FirstOrDefault();

        if (string.IsNullOrWhiteSpace(primaryKeyName))
            return 0;

        var keyProperty = pending.Entry.Property(primaryKeyName);
        var keyValue = pending.State == EntityState.Deleted
            ? keyProperty.OriginalValue
            : keyProperty.CurrentValue ?? keyProperty.OriginalValue;

        return keyValue != null && int.TryParse(keyValue.ToString(), out var id) ? id : 0;
    }

    private sealed class PendingAuditLog
    {
        public required EntityEntry Entry { get; init; }
        public required EntityState State { get; init; }
        public required string EntityName { get; init; }
        public string? OldDataJson { get; init; }
        public string? NewDataJson { get; init; }
        public string? UserId { get; init; }
    }

    private static void ApplyBaseAuditFields(
        IReadOnlyList<LOG_AUDIT> entities,
        IReadOnlyList<PendingAuditLog> pending,
        int actionBy)
    {
        var createdByProp = typeof(LOG_AUDIT).GetProperty("CreatedBy");
        var createdDateProp = typeof(LOG_AUDIT).GetProperty("CreatedDate");
        var updatedByProp = typeof(LOG_AUDIT).GetProperty("UpdatedBy");
        var updatedDateProp = typeof(LOG_AUDIT).GetProperty("UpdatedDate");
        var now = DateTime.UtcNow;

        for (var i = 0; i < entities.Count; i++)
        {
            var user = pending[i].UserId ?? actionBy.ToString();
            createdByProp?.SetValue(entities[i], user);
            updatedByProp?.SetValue(entities[i], user);
            createdDateProp?.SetValue(entities[i], now);
            updatedDateProp?.SetValue(entities[i], now);
        }
    }

    private async Task<int> ResolveActionByAsync(string? userId, CancellationToken cancellationToken)
    {
        if (string.IsNullOrWhiteSpace(userId))
            throw new InvalidOperationException("Audit user context is missing.");

        var mappedByEmployeeId = await _dbContext.Set<M_USER>()
            .AsNoTracking()
            .Where(u => u.EmployeeId == userId)
            .Select(u => u.Id)
            .FirstOrDefaultAsync(cancellationToken);

        if (mappedByEmployeeId > 0)
            return mappedByEmployeeId;

        throw new InvalidOperationException(
            $"Cannot map audit user '{userId}' to M_USER.Id.");
    }
}
