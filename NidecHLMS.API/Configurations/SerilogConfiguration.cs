using Serilog;

namespace NidecHLMS.API.Configurations
{
    public static class SerilogConfiguration
    {
        public static void AddSerilogConfig(this WebApplicationBuilder builder)
        {
            builder.Host.UseSerilog((ctx, services, config) => config
                .ReadFrom.Configuration(ctx.Configuration)
                .ReadFrom.Services(services)
                .Enrich.FromLogContext()
                .Enrich.WithMachineName()
                .Enrich.WithThreadId()
                .Enrich.WithProperty("Application", "NidecHLMS")
                .WriteTo.Console()
                .WriteTo.File("logs/nidec-.log", rollingInterval: RollingInterval.Day)
            );
        }
    }
}