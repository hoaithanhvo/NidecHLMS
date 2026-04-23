using Application;
using Infrastructure;
using NidecHLMS.API.Middlewares.Exceptions;
using Persistence;

namespace NidecHLMS.API.Configurations;

public static class ServiceConfiguration
{
    public const string CorsPolicyName = "NidecHLMSCorsPolicy";

    public static IServiceCollection AddApiServices(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddControllers();
        services.AddGrpc(options =>
        {
            options.EnableDetailedErrors = true;
            options.Interceptors.Add<GrpcExceptionMiddleware>();
        });
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.AddHttpContextAccessor();
        services.AddCors(options =>
        {
            options.AddPolicy(CorsPolicyName, policy =>
            {
                var allowedOrigins = configuration
                    .GetSection("Cors:AllowedOrigins")
                    .Get<string[]>();

                if (allowedOrigins is { Length: > 0 })
                    policy.WithOrigins(allowedOrigins)
                          .AllowAnyHeader()
                          .AllowAnyMethod()
                          .AllowCredentials();
                else
                    policy.AllowAnyOrigin()
                          .AllowAnyHeader()
                          .AllowAnyMethod();
            });
        });

        // Each layer reads its own config internally, now we pass IConfiguration
        services.AddApplication();
        services.AddPersistence(configuration);      
        services.AddInfrastructure(configuration);

        return services;
    }
}
