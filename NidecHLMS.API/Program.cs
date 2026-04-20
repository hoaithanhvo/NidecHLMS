using Application.Features.Trainings.Commands.Create;
using Application.Mapping;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using NidecHLMS.API.Configurations;
using NidecLocationVisualize.Api.API.Configs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Serilog Configuration
builder.AddSerilogConfig();

// Service Registrations (API, Application, Persistence, Infrastructure)
builder.Services.AddApiServices(builder.Configuration);

//AutoMapper
builder.Services.AddAutoMapper(cfg => { }, typeof(Program).Assembly);


//Validation
builder.Services.AddValidatorsFromAssemblyContaining<CreateTrainingValidator>();

// Add services to the container.
builder.Services.AddHttpContextAccessor();

// Add versioning services
builder.AddApiVersioningServices();


var app = builder.Build();

// Configure the HTTP request pipeline (Middlewares, Serilog, Swagger, etc.)
app.UseApiMiddlewares();

app.MapControllers();

app.Run();
