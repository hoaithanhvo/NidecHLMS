using Application.Common.Exceptions;
using Application.Common.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Server.IIS;
using System.Text.Json;

namespace NidecHLMS.API.Middlewares.Exceptions
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionHandlingMiddleware> _logger;
        private static readonly JsonSerializerOptions _jsonSerializerOptions = new()
        {
            // Configures how the JSON response will be formatted camelCase, no extra whitespace
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = false
        };

        public ExceptionHandlingMiddleware(RequestDelegate next, ILogger<ExceptionHandlingMiddleware> logger)
        {
            _logger = logger;
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                // Pass the request to the next middleware in the pipeline
                await _next(context);
            }
            catch (Exception e)
            {
                //any middleware or controller throws an exception, catch it here
                await HandleExceptionAsync(context, e);
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            //Map the exception type to specific HTTP status codes and messages
            var (statusCode, message, errors) = MapException(exception);

            if (statusCode >= 500)
                _logger.LogError(exception,
                    "Unhandled exception [{StatusCode}] {Method} {Path}: {Message}",
                    statusCode, context.Request.Method, context.Request.Path, exception.Message);
            else
                _logger.LogWarning(
                    "Handled exception [{StatusCode}] {Method} {Path}: {Message}",
                    statusCode, context.Request.Method, context.Request.Path, exception.Message);

            //Set up the HTTP response headers for returning JSON
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = statusCode;

            //Wrap the error details in your standardized ApiResponse envelope
            var response = ApiResponse<object>.Fail(
                message,
                errors,
                context.TraceIdentifier
            );

            //Serialize and write the response back to the client
            await context.Response.WriteAsync(
                JsonSerializer.Serialize(response, _jsonSerializerOptions));
        }


        private static (int StatusCode, string Message, IReadOnlyList<ValidationError>? Errors)
         MapException(Exception ex) => ex switch
         {
             // 404 Not Found
             NotFoundException e => (404, e.Message, null),
             //400 Bad Request
             ValidationException e => (400, e.Message, e.Errors),
             BadRequestException e => (400, e.Message, null),
             // 409 Conflict
             ConflictException e => (409, e.Message, null),
             // 403 Forbidden
             ForbiddenAccessException e => (403, e.Message, null),
             // 401 Unauthorized
             UnauthorizedException e => (401, e.Message, null),
             // 500 Internal Error Server
             _ => (500, "An unexpected error occurred. Please contact support.", null)
         };
    }
}
