using FluentValidation;
using Application.Common.Behaviors;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Application
{
    public static class DependencyInjection 
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();
            
            // AutoMapper — discovers all Profile classes in this assembly
            services.AddAutoMapper(assembly);

            services.AddValidatorsFromAssembly(assembly);

            //MediatR + pipeline behaviors
            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssembly(assembly);

                //logging wrap everything, log entry/exit/error
                cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(LoggingBehavior<,>));

                //Validation throw exception before handler if invalid
                cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

                //Audit Log reads ChangeTracker before Commit (Inner)
                cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(AuditBehavior<,>));

                //Transaction commit handler success (Outer)
                cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(TransactionBehavior<,>));
            });
            return services;
        }
    }
}
