using NidecHLMS.API.Middlewares.Exceptions;
using Serilog;

namespace NidecHLMS.API.Configurations
{
    public static class MiddlewareConfiguration
    {
        public static WebApplication UseApiMiddlewares(this WebApplication app)
        {
            app.UseMiddleware<ExceptionHandlingMiddleware>();

            app.UseSerilogRequestLogging(options =>
            {
                options.MessageTemplate =
                    "HTTP {RequestMethod} {RequestPath} → {StatusCode} in {Elapsed:0.0000}ms";

                options.EnrichDiagnosticContext = (ctx, http) =>
                {
                    ctx.Set("RequestHost", http.Request.Host.Value);
                    ctx.Set("RequestScheme", http.Request.Scheme);
                    ctx.Set("UserAgent", http.Request.Headers["User-Agent"]);
                };
            });

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();

            return app;
        }
    }
}