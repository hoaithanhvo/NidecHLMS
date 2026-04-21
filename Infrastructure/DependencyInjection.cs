using Application.Common.Interfaces;
using Application.Interfaces.Services;
using Infrastructure.GrpcClient.Interceptors;
using Infrastructure.GrpcClient.ProtosFile;

//using Infrastructure.GrpcClient.ProtosFile;
using Infrastructure.GrpcClient.Services;
using Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHttpClient();

			// Example services
			services.AddScoped(typeof(IQueryRepository<>), typeof(QueryRepository<>));
			services.AddScoped(typeof(ICommandRepository<>), typeof(CommandRepository<>));

            services.AddScoped<GrpcClientExceptionInterceptor>();
            services.AddGrpcUserClient(configuration);
            services.AddScoped<IUserGrpcService, UserGrpcService>();
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
    }
}