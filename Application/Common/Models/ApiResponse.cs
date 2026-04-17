namespace Application.Common.Models;

public class ApiResponse<T>
{
    public bool Success { get; init; }
    public string Message { get; init; } = string.Empty;
    public T? Data { get; init; }
    public IReadOnlyList<ValidationError>? Errors { get; init; }
    public string? TraceId { get; init; }

    public static ApiResponse<T> Ok(T data, 
        string message = "Success.")
        => new() 
        { Success = true, 
          Message = message,
          Data = data };

    public static ApiResponse<T> Fail(
        string message,
        IReadOnlyList<ValidationError>? errors = null,
        string? traceId = null)
        => new()
        {
            Success = false,
            Message = message,
            Errors = errors,
            TraceId = traceId
        };
}