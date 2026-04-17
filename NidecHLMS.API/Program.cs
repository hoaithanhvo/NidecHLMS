using NidecHLMS.API.Configurations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Serilog Configuration
builder.AddSerilogConfig();

// Service Registrations (API, Application, Persistence, Infrastructure)
builder.Services.AddApiServices(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline (Middlewares, Serilog, Swagger, etc.)
app.UseApiMiddlewares();

app.MapControllers();

app.Run();
