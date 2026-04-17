using Application.Common.Exceptions;
using Application.Common.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Server.IIS;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace NidecHLMS.API.Middlewares.Exceptions
{
    public class ExceptionHandingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionHandingMiddleware> _logger;
        private static readonly JsonSerializerOptions _jsonSerializerOptions = new()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = false
        };

        public ExceptionHandingMiddleware(RequestDelegate next, ILogger<ExceptionHandingMiddleware> logger)
        {
            _logger = logger;
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception e)
            {
                await HandleExceptionAsync(context, e);
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            var (statusCode, message, errors) = MapException(exception);

            if (statusCode >= 500)
                _logger.LogError(exception,
                    "Unhandled exception [{StatusCode}] {Method} {Path}: {Message}",
                    statusCode, context.Request.Method, context.Request.Path, exception.Message);
            else
                _logger.LogWarning(
                    "Handled exception [{StatusCode}] {Method} {Path}: {Message}",
                    statusCode, context.Request.Method, context.Request.Path, exception.Message);

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = statusCode;

            var response = ApiResponse<object>.Fail(
                message,
                errors,
                context.TraceIdentifier
            );

            await context.Response.WriteAsync(
                JsonSerializer.Serialize(response, _jsonSerializerOptions));
        }


        private static (int StatusCode, string Message, IReadOnlyList<ValidationError>? Errors)
         MapException(Exception ex) => ex switch
         {
             NotFoundException e => (404, e.Message, null),
             Application.Common.Exceptions.ValidationException e => (400, e.Message, e.Errors),
             BadRequestException e => (400, e.Message, null),
             ConflictException e => (409, e.Message, null),
             ForbiddenAccessException e => (403, e.Message, null),

             _ => (500, "An unexpected error occurred. Please contact support.", null)
         };
    }
}
