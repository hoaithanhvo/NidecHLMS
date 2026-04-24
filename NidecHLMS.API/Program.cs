using Application.Mapping;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using NidecHLMS.API.Configurations;
using NidecLocationVisualize.Api.API.Configs;
using Serilog;
using Serilog.Events;

// Captures fatal errors that happen BEFORE UseSerilog() is configured
Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
    .WriteTo.Console()
    .CreateBootstrapLogger();

try
{
    var builder = WebApplication.CreateBuilder(args);

    // Serilog (replaces default Microsoft logging)
    builder.AddSerilogConfig();

    // All service registrations (API + Application + Persistence + Infrastructure)
    builder.Services.AddApiServices(builder.Configuration);

    //AutoMapper
    //builder.Services.AddAutoMapper(cfg => { }, typeof(Program).Assembly);

    // JWT swagger security
    builder.Services.AddSwaggerGen(c =>
    {
        c.AddSecurityDefinition("Bearer", new Microsoft.OpenApi.Models.OpenApiSecurityScheme
        {
            Name = "Authorization",
            Type = Microsoft.OpenApi.Models.SecuritySchemeType.Http,
            Scheme = "Bearer",
            BearerFormat = "JWT",
            In = Microsoft.OpenApi.Models.ParameterLocation.Header,
            Description = "Enter 'Bearer {token}'"
        });

        c.AddSecurityRequirement(new Microsoft.OpenApi.Models.OpenApiSecurityRequirement
    {
        {
            new Microsoft.OpenApi.Models.OpenApiSecurityScheme
            {
                Reference = new Microsoft.OpenApi.Models.OpenApiReference
                {
                    Type = Microsoft.OpenApi.Models.ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] {}
        }
    });
    });

    //AutoMapper
    builder.Services.AddAutoMapper(cfg => { }, 
    typeof(Program).Assembly, 
    typeof(TrainingMappingProfile).Assembly);

	// Add versioning services
	builder.AddApiVersioningServices();
	var app = builder.Build();

    // All middleware pipeline configuration
    app.UseApiMiddlewares();

	app.Run();
}
catch (Exception ex) when (ex is not HostAbortedException)
{
    // HostAbortedException is thrown intentionally by .NET during EF migrations
    // or test host teardown � do not treat it as a crash
    Log.Fatal(ex, "Application terminated unexpectedly");
}
finally
{
    await Log.CloseAndFlushAsync();
}
