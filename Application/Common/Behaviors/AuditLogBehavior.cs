using Application.Interfaces.Command;
using Application.Interfaces.Persistence;
using Application.Interfaces.Services;
using MediatR;

namespace Application.Common.Behaviors
{
    public class AuditBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {
        private readonly IAuditLogCollector _auditLogCollector;
        private readonly ICurrentUserService _currentUserService;

        public AuditBehavior(
            IAuditLogCollector auditLogCollector,
			ICurrentUserService currentUserService)
        {
            _auditLogCollector = auditLogCollector;
			_currentUserService = currentUserService;
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
				_auditLogCollector.Capture(_currentUserService.GetUserId);
			}

			return response;
        }
    }
}

