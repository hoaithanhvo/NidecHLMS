namespace Application.Common.Models;

public class ApiResponse<T>
{
    public bool Success { get; init; }
    public int StatusCode { get; init; }
    public string Message { get; init; } = string.Empty;
    public T? Data { get; init; }
    public IReadOnlyList<ValidationError>? Errors { get; init; }
    public string TraceId { get; init; } = string.Empty;
    public string Version { get; init; } = string.Empty;
    public string Path { get; init; } = string.Empty;
    public string Timespan { get; init; } = "00:00:00.000";

    public static ApiResponse<T> Ok(
        T data,
        string? message = null,
        int statusCode = 200,
        string version = "1.0",
        string path = "",
        string traceId = "",
        string timeSpan = "00:00:00.000")
        => new()
        {
            Success = true,
            StatusCode = statusCode,
            Message = message ?? "Success.",
            Data = data,
            TraceId = traceId,
            Version = version,
            Path = path,
            Timespan = timeSpan
        };

    public static ApiResponse<T> Fail(
        string message,
        IReadOnlyList<ValidationError>? errors = null,
        int statusCode = 500,
        string version = "1.0",
        string path = "",
        string traceId = "",
        string timeSpan = "00:00:00.000")
        => new()
        {
            Success = false,
            StatusCode = statusCode,
            Message = message,
            Errors = errors,
            TraceId = traceId,
            Version = version,
            Path = path,
            Timespan = timeSpan
        };
}
