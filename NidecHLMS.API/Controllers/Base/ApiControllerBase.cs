using Application.Common.Models;
using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Globalization;

namespace NidecHLMS.API.Controllers.Base
{
    /// <summary>
    /// Shared base controller for standardized API response envelopes.
    /// </summary>
    [ApiController]
    [Route("api/v1/[controller]")]
    public abstract class ApiControllerBase : ControllerBase
    {
        private const string RequestStopwatchItemKey = "RequestStopwatch";
        private readonly IHttpContextAccessor _contextAccessor;

        protected ApiControllerBase(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }

        protected ApiResponse<T> CreateResponse<T>(T data, string? message = null, int statusCode = 200)
        {
            return ApiResponse<T>.Ok(
                data,
                message,
                statusCode,
                GetApiVersion(),
                GetPath(),
                GetTraceId(),
                GetRequestElapsed());
        }

        protected ApiResponse<T> CreateErrorResponse<T>(string message, int statusCode = 400)
        {
            return ApiResponse<T>.Fail(
                message,
                null,
                statusCode,
                GetApiVersion(),
                GetPath(),
                GetTraceId(),
                GetRequestElapsed());
        }

        private string GetTraceId()
            => string.IsNullOrWhiteSpace(_contextAccessor.HttpContext?.TraceIdentifier)
                ? Guid.NewGuid().ToString("N")
                : _contextAccessor.HttpContext!.TraceIdentifier;

        private string GetApiVersion()
        {
            return _contextAccessor.HttpContext?.GetRequestedApiVersion()?.ToString() ?? "1.0";
        }

        private string GetPath()
        {
            return _contextAccessor.HttpContext?.Request.Path.ToString() ?? string.Empty;
        }

        private string GetRequestElapsed()
        {
            if (_contextAccessor.HttpContext?.Items.TryGetValue(RequestStopwatchItemKey, out var stopwatchObj) == true &&
                stopwatchObj is Stopwatch stopwatch)
            {
                return stopwatch.Elapsed.ToString(@"hh\:mm\:ss\.fff", CultureInfo.InvariantCulture);
            }

            return TimeSpan.Zero.ToString(@"hh\:mm\:ss\.fff", CultureInfo.InvariantCulture);
        }
    }
}
