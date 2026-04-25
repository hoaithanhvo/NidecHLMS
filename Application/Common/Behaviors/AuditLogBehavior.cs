using Application.Interfaces.Command;
using Application.Interfaces.Common;
using Application.Interfaces.Persistence;
using Application.Interfaces.Services;
using MediatR;

namespace Application.Common.Behaviors
{
    public class AuditBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {
        private readonly IAuditLogCollector _auditLogCollector;
        private readonly IAuditableEntityStamper _auditableEntityStamper;
        private readonly ICurrentUserContext _currentUserContext;

        public AuditBehavior(
            IAuditLogCollector auditLogCollector,
            IAuditableEntityStamper auditableEntityStamper,
            ICurrentUserContext currentUserContext)
        {
            _auditLogCollector = auditLogCollector;
            _auditableEntityStamper = auditableEntityStamper;
            _currentUserContext = currentUserContext;
        }

        public async Task<TResponse> Handle(
            TRequest request,
            RequestHandlerDelegate<TResponse> next,
            CancellationToken cancellationToken)
        {
            var response = await next();

            if (request is ICommand<TResponse>)
            {
                var actor = _currentUserContext.UserId;
                if (string.IsNullOrWhiteSpace(actor))
                    throw new InvalidOperationException("Audit user context is missing.");

                _auditableEntityStamper.StampAuditableEntities(actor);
                _auditLogCollector.Capture(actor, _currentUserContext.RequestPath);
            }

			return response;
        }
    }
}

