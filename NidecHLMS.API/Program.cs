using Application.Features.Trainings.Commands.Create;
using Application.Mapping;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using NidecHLMS.API.Configurations;
using Serilog;
using Serilog.Events;
using NidecLocationVisualize.Api.API.Configs;

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