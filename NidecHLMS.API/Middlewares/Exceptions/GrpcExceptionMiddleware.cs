using Application.Common.Exceptions;
using Grpc.Core;
using Grpc.Core.Interceptors;

namespace NidecHLMS.API.Middlewares.Exceptions;

public class GrpcExceptionMiddleware : Interceptor
{
    private readonly ILogger<GrpcExceptionMiddleware> _logger;

    public GrpcExceptionMiddleware(ILogger<GrpcExceptionMiddleware> logger)
    {
        _logger = logger;
    }

    public override async Task<TResponse> UnaryServerHandler<TRequest, TResponse>(
        TRequest request,
        ServerCallContext context,
        UnaryServerMethod<TRequest, TResponse> continuation)
    {
        try
        {
            return await continuation(request, context);
        }
        catch (RpcException)
        {
            throw;
        }
        catch (Exception ex)
        {
            var status = ex switch
            {
                ValidationException => new Status(StatusCode.InvalidArgument, ex.Message),
                NotFoundException => new Status(StatusCode.NotFound, ex.Message),
                UnauthorizedException => new Status(StatusCode.Unauthenticated, ex.Message),
                ForbiddenAccessException => new Status(StatusCode.PermissionDenied, ex.Message),
                ConflictException => new Status(StatusCode.Aborted, ex.Message),
                BadRequestException => new Status(StatusCode.InvalidArgument, ex.Message),
                _ => new Status(StatusCode.Internal, "An unexpected gRPC error occurred.")
            };

            _logger.LogError(ex, "Unhandled gRPC exception. Method: {Method}", context.Method);
            throw new RpcException(status);
        }
    }
}
