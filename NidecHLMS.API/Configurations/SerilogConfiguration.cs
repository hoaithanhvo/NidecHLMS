using Serilog;

namespace NidecHLMS.API.Configurations;

public static class SerilogConfiguration
{
    public static void AddSerilogConfig(this WebApplicationBuilder builder)
    {
        builder.Host.UseSerilog((ctx, services, config) => config
            .ReadFrom.Configuration(ctx.Configuration)  // reads Serilog section from appsettings.json
            .ReadFrom.Services(services)
            .Enrich.FromLogContext()
            .Enrich.WithMachineName()
            .Enrich.WithThreadId()
            .Enrich.WithProperty("Application", "NidecHLMS")
        );
    }
}
