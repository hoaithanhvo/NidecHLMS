using Application.Common.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace NidecHLMS.API.Controllers.Base
{
    /// <summary>
    /// Base API Controller following modern CQRS .NET 
    /// Provides a lazy-loaded MediatR ISender No need to inject it in every controller constructor
    /// Provides strongly typed success/failure response wrappers using ApiResponse<T>
    /// </summary>
    [ApiController]
    [Route("api/v1/[controller]")]
    public abstract class ApiControllerBase : ControllerBase
    {
        private ISender? _mediator;

        // Lazy load ISender to avoid constructor injection clutter in derived classes
        protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetRequiredService<ISender>();

        /// <summary>
        /// Wraps the result in an Ok 200 response with standard ApiResponse format
        /// </summary>
        protected IActionResult OkResponse<T>(T data, string message = "Success.")
        {
            return Ok(ApiResponse<T>.Ok(data, message));
        }

        /// <summary>
        /// Wraps the result in a Created (201) response with standard ApiResponse format
        /// </summary>
        protected IActionResult CreatedResponse<T>(string uri, T data, string message = "Resource created successfully.")
        {
            return Created(uri, ApiResponse<T>.Ok(data, message));
        }

        /// <summary>
        /// Wraps manual failures though ExceptionHandlingMiddleware should catch most of them
        /// </summary>
        protected IActionResult ErrorResponse<T>(string message, int statusCode = 400)
        {
            var traceId = HttpContext.TraceIdentifier; 
            var response = ApiResponse<T>.Fail(message, null, traceId);

            return StatusCode(statusCode, response);
        }
    }
}
