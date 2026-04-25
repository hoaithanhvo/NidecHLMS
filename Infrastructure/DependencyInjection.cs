using Application.Interfaces.Persistence;
using Application.Interfaces.Repositories;
using Application.Interfaces.Services;
using Application.Service.WorkflowService;
using Domain.Enrollment.Factories;
using Infrastructure.Factories;
using Infrastructure.GrpcClient.Interceptors;
using Infrastructure.GrpcClient.ProtosFile;
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
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddHttpClient();

            services.AddRepositories();
            services.AddExternalServices(configuration);
            services.AddGrpcServices(configuration);
            services.AddCaching();
            services.AddScoped<ICurrentUserService, CurrentUserService>();
            services.AddScoped<IEnrollmentStateFactory, EnrollmentStateFactory>();
            return services;
        }

        private static void AddGrpcServices(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddScoped<GrpcClientExceptionInterceptor>();

            var grpcServerUrl =
                configuration["GrpcSettings:UserServiceUrl"]
                ?? configuration["GrpcSettings:IdmServiceUrl"]
                ?? throw new InvalidOperationException(
                    "gRPC user service URL is not configured. Set either 'GrpcSettings:UserServiceUrl' or legacy 'GrpcSettings:IdmServiceUrl'.");

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

            services.AddScoped<IUserGrpcService, UserGrpcService>();
        }
        // Repositories 
        private static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(ICommandRepository<,>), typeof(GenericRepository<,>));
            services.AddScoped(typeof(IGenericRepository<,>), typeof(GenericRepository<,>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IWorkflowService, WorkflowService>();
            services.AddScoped<IAuditLogCollector, AuditLogCollector>();
        }

        private static void AddExternalServices(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            var idmBaseUrl = configuration["IDM:BaseUrl"];
            if (string.IsNullOrWhiteSpace(idmBaseUrl))
                throw new InvalidOperationException("IDM:BaseUrl is not configured.");

            services.AddHttpClient<IUserRestApiService, UserRestApiService>(client =>
            {
                client.BaseAddress = new Uri(EnsureTrailingSlash(idmBaseUrl));
            });

            services.AddHttpClient<ITokenManager, TokenManager>(client =>
            {
                client.BaseAddress = new Uri(EnsureTrailingSlash(idmBaseUrl));
            });
        }

        private static void AddCaching(this IServiceCollection services)
        {
            services.AddMemoryCache();
            services.AddSingleton<ICacheService, CacheService>();
        }

        private static string EnsureTrailingSlash(string url)
            => url.EndsWith("/", StringComparison.Ordinal) ? url : $"{url}/";
    }
}
