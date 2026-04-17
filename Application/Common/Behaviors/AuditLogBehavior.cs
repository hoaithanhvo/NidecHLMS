using Application.Interfaces.Command;
using Application.Interfaces.Persistence;
using Application.Interfaces.Repositories;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Application.Common.Behaviors
{
    public class AuditBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest : ICommand<TResponse>
    {
        private readonly IApplicationDbContext _context;

        public AuditBehavior(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<TResponse> Handle(
            TRequest request,
            RequestHandlerDelegate<TResponse> next,
            CancellationToken cancellationToken)
        {
            var response = await next();

            var auditLogs = new List<AUDITLOG>();

            var entries = _context.ChangeTracker.Entries()
                .Where(e => e.Entity is not AUDITLOG &&
                            e.State != EntityState.Detached &&
                            e.State != EntityState.Unchanged)
                .ToList();

            foreach (var entry in entries)
            {
                var audit = new AUDITLOG
                {
                    Entity = entry.Entity.GetType().Name,
                    Action = entry.State.ToString()
                };

                var pkName = entry.Metadata.FindPrimaryKey()?.Properties
                    .Select(x => x.Name)
                    .SingleOrDefault();

                if (pkName != null)
                {
                    var pkValue = entry.Property(pkName).CurrentValue;

                    if (pkValue != null && int.TryParse(pkValue.ToString(), out int id))
                    {
                        audit.RecordId = id;
                    }
                }

                var oldValues = new Dictionary<string, object?>();
                var newValues = new Dictionary<string, object?>();

                foreach (var prop in entry.Properties)
                {
                    if (prop.IsTemporary) continue;

                    switch (entry.State)
                    {
                        case EntityState.Added:
                            newValues[prop.Metadata.Name] = prop.CurrentValue;
                            break;

                        case EntityState.Deleted:
                            oldValues[prop.Metadata.Name] = prop.OriginalValue;
                            break;

                        case EntityState.Modified:
                            if (prop.IsModified)
                            {
                                oldValues[prop.Metadata.Name] = prop.OriginalValue;
                                newValues[prop.Metadata.Name] = prop.CurrentValue;
                            }
                            break;
                    }
                }

                //check all workflow 

                if (oldValues.Any())
                    audit.OldData = JsonSerializer.Serialize(oldValues);

                if (newValues.Any())
                    audit.NewData = JsonSerializer.Serialize(newValues);

                auditLogs.Add(audit);
            }

            if (auditLogs.Any())
            {
                await _context.AuditLogs.AddRangeAsync(auditLogs, cancellationToken);
            }

            return response;
        }
    }
}

