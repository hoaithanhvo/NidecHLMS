using Application.Features.Trainings.Commands.Create;
using Application.Mapping;
using FluentValidation;
using Infrastructure.GrpcClient.Services;
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
	builder.Services.AddAutoMapper(cfg => { }, typeof(Program).Assembly);

	//GRPC 
	builder.Services.AddGrpc();

	// Add versioning services
	builder.AddApiVersioningServices();
	var app = builder.Build();

    // All middleware pipeline configuration
    app.UseApiMiddlewares();

	app.MapGrpcService<UserGrpcService>(); // 👈 BẮT BUỘC
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