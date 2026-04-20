using Application;
using Persistence;
using Infrastructure;

namespace NidecHLMS.API.Configurations
{
    public static class ServiceConfiguration
    {
        public static IServiceCollection AddApiServices(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            services.AddApplication();
            services.AddPersistence(configuration);
            services.AddInfrastructure(configuration);

            return services;
        }
    }
}
