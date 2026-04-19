using Grpc.Core;
using Grpc.Core.Interceptors;
using Microsoft.Extensions.Logging;

namespace Infrastructure.GrpcClient.Interceptors;

public sealed class GrpcClientExceptionInterceptor : Interceptor
{
    private readonly ILogger<GrpcClientExceptionInterceptor> _logger;

    public GrpcClientExceptionInterceptor(ILogger<GrpcClientExceptionInterceptor> logger)
    {
        _logger = logger;
    }

    public override AsyncUnaryCall<TResponse> AsyncUnaryCall<TRequest, TResponse>(
        TRequest request,
        ClientInterceptorContext<TRequest, TResponse> context,
        AsyncUnaryCallContinuation<TRequest, TResponse> continuation)
    {
        var call = continuation(request, context);

        return new AsyncUnaryCall<TResponse>(
            HandleResponseAsync(call.ResponseAsync, context.Method.FullName),
            call.ResponseHeadersAsync,
            call.GetStatus,
            call.GetTrailers,
            call.Dispose);
    }

    private async Task<TResponse> HandleResponseAsync<TResponse>(
        Task<TResponse> responseTask,
        string methodName)
    {
        try
        {
            return await responseTask;
        }
        catch (RpcException ex)
        {
            _logger.LogError(
                ex,
                "gRPC call failed. Method: {Method}. StatusCode: {StatusCode}. Detail: {Detail}",
                methodName,
                ex.StatusCode,
                ex.Status.Detail);
            throw;
        }
    }
}
