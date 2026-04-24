using Application.Interfaces.Persistence;
using Application.Interfaces.Repositories;
using Application.Interfaces.Services;
using Application.Service.WorkflowService;
using Domain.Enrollment.Factories;
using Infrastructure.Factories;
using Infrastructure.GrpcClient.Interceptors;
using Infrastructure.GrpcClient.ProtosFile;
//using Infrastructure.GrpcClient.ProtosFile;
using Infrastructure.GrpcClient.Services;
using Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Auditing;
using Persistence.Repositories;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHttpClient();
            services.AddRepositories();
            // Example services
			services.AddScoped<ICurrentUserService, CurrentUserService>();
			services.AddScoped<GrpcClientExceptionInterceptor>();
            services.AddGrpcUserClient(configuration);
            services.AddScoped<IUserGrpcService, UserGrpcService>();
            services.AddScoped<IEnrollmentStateFactory, EnrollmentStateFactory>();
			return services;
        }

        private static IServiceCollection AddGrpcUserClient(this IServiceCollection services, IConfiguration configuration)
        {
            var grpcServerUrl = configuration["GrpcSettings:UserServiceUrl"]
                ?? throw new InvalidOperationException("GrpcSettings:UserServiceUrl is not configured.");

            services.AddGrpcClient<ServiceGetUser.ServiceGetUserClient>(options =>
            {
                options.Address = new Uri(grpcServerUrl);
            })
            .AddInterceptor<GrpcClientExceptionInterceptor>()
            .ConfigureChannel(options =>
            {
                options.MaxReceiveMessageSize = 5 * 1024 * 1024;
                options.MaxSendMessageSize = 2 * 1024 * 1024;
            })
            .ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback =
                    HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            });

            return services;
        }
        // Repositories 
        private static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(ICommandRepository<,>), typeof(GenericRepository<,>));
            services.AddScoped(typeof(IGenericRepository<,>), typeof(GenericRepository<,>));
            services.AddScoped<IAuditLogCollector, AuditLogCollector>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IWorkflowService, WorkflowService>();
        }
    }
}