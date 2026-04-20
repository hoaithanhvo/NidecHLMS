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
            
            // mapper discovers all Profile classes in this assembly
            services.AddAutoMapper(assembly);

            services.AddValidatorsFromAssembly(assembly);

            // mediatR + pipeline behaviors
            // 
            //  registration order = outermost → innermost      
            //                                                          
            //  Logging  > Validation > Transaction > Audit > Handler  
            //  (outer)                                      (inner)   
            //                                                         
            //  transaction begins BEFORE handler, commits AFTER audit 
            //  audit reads ChangeTracker AFTER handler, BEFORE commit 
            // 
            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssembly(assembly);

                // 1. Logging (outermost) — logs entry/exit/elapsed/errors for every request
                cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(LoggingBehavior<,>));

                // 2. Validation — throws ValidationException before handler if invalid
                cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

                // 3. Transaction (outer) — begins transaction, commits on success with audit included
                cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(TransactionBehavior<,>));

                // 4. Audit (inner) — reads ChangeTracker AFTER handler, adds LOG_AUDIT rows BEFORE commit
                cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(AuditBehavior<,>));
            });
            return services;
        }
    }
}
