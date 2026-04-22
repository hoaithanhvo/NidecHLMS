using Application.Interfaces.Command;
using Application.Interfaces.Common;
using Application.Interfaces.Persistence;
using MediatR;

namespace Application.Common.Behaviors
{
    public class AuditBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {
        private readonly IAuditLogCollector _auditLogCollector;
        private readonly ICurrentUserContext _currentUserContext;

        public AuditBehavior(
            IAuditLogCollector auditLogCollector,
            ICurrentUserContext currentUserContext)
        {
            _auditLogCollector = auditLogCollector;
            _currentUserContext = currentUserContext;
        }

        public async Task<TResponse> Handle(
            TRequest request,
            RequestHandlerDelegate<TResponse> next,
            CancellationToken cancellationToken)
        {
            var response = await next();

			// ✅ chỉ audit command
			if(request is ICommand<TResponse>)
			{
				_auditLogCollector.Capture(_currentUserContext.UserId);
			}

			return response;
        }
    }
}

