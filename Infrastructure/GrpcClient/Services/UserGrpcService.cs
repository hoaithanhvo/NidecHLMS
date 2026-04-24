using Application.DTOs.Responses;
using Application.Interfaces.Services;
using Grpc.Core;
using Infrastructure.GrpcClient.ProtosFile;
using Microsoft.Extensions.Logging;

namespace Infrastructure.GrpcClient.Services;

public class UserGrpcService : IUserGrpcService
{
    private static readonly TimeSpan UserCacheDuration = TimeSpan.FromHours(6);
    private const string UserCachePrefix = "idm-user:";

    private readonly ServiceGetUser.ServiceGetUserClient _serviceClient;
    private readonly IUserRestApiService _userRestApiService;
    private readonly ICacheService _cacheService;
    private readonly ILogger<UserGrpcService> _logger;

    public UserGrpcService(
        ServiceGetUser.ServiceGetUserClient serviceClient,
        IUserRestApiService userRestApiService,
        ICacheService cacheService,
        ILogger<UserGrpcService> logger)
    {
        _serviceClient = serviceClient;
        _userRestApiService = userRestApiService;
        _cacheService = cacheService;
        _logger = logger;
    }
    
    public async Task<UserResponse> GetUser(string userId)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(userId);
        var normalizedUserId = userId.Trim();

        var cached = _cacheService.Get<UserResponse>(BuildUserCacheKey(normalizedUserId));
        if (cached != null)
            return cached;

        try
        {
            var user = await _serviceClient.GetUserByUserIdAsync(new UserIdRequest { UserId = normalizedUserId });
            var mapped = MapUser(user);
            CacheUser(mapped);
            return mapped;
        }
        catch (RpcException ex)
        {
            _logger.LogWarning(ex, "gRPC user lookup failed for UserId {UserId}. Falling back to REST.", normalizedUserId);
        }

        var fallbackUser = await _userRestApiService.GetUser(normalizedUserId);
        CacheUser(fallbackUser);
        return fallbackUser;
    }

    public async Task<List<UserResponse>> GetUsers(List<string> userIds)
    {
        ArgumentNullException.ThrowIfNull(userIds);

        var normalizedIds = userIds
            .Where(x => !string.IsNullOrWhiteSpace(x))
            .Select(x => x.Trim())
            .Distinct(StringComparer.OrdinalIgnoreCase)
            .ToList();

        if (normalizedIds.Count == 0)
            return [];

        var resultByUserId = new Dictionary<string, UserResponse>(StringComparer.OrdinalIgnoreCase);
        var missingIds = new List<string>();

        foreach (var normalizedId in normalizedIds)
        {
            var cached = _cacheService.Get<UserResponse>(BuildUserCacheKey(normalizedId));
            if (cached != null && !string.IsNullOrWhiteSpace(cached.UserId))
            {
                resultByUserId[cached.UserId!] = cached;
                continue;
            }

            missingIds.Add(normalizedId);
        }

        if (missingIds.Count > 0)
        {
            List<UserResponse> grpcUsers = [];
            try
            {
                var request = new UserIdsRequest();
                request.UserIds.Add(missingIds);

                var grpcResponse = await _serviceClient.GetUsersByUserIdsAsync(request);
                grpcUsers = grpcResponse.Users.Select(MapUser).ToList();
            }
            catch (RpcException ex)
            {
                _logger.LogWarning(ex, "gRPC batch user lookup failed. Falling back to REST for {Count} users.", missingIds.Count);
            }

            foreach (var grpcUser in grpcUsers.Where(x => !string.IsNullOrWhiteSpace(x.UserId)))
            {
                resultByUserId[grpcUser.UserId!] = grpcUser;
                CacheUser(grpcUser);
            }

            var unresolvedIds = missingIds
                .Where(id => !resultByUserId.ContainsKey(id))
                .ToList();

            if (unresolvedIds.Count > 0)
            {
                var restUsers = await _userRestApiService.GetUsers(unresolvedIds);
                foreach (var restUser in restUsers.Where(x => !string.IsNullOrWhiteSpace(x.UserId)))
                {
                    resultByUserId[restUser.UserId!] = restUser;
                    CacheUser(restUser);
                }
            }
        }

        return normalizedIds
            .Where(resultByUserId.ContainsKey)
            .Select(id => resultByUserId[id])
            .ToList();
    }

    private static UserResponse MapUser(GetUserByUserIdResponse user)
    {
        return new UserResponse
        {
            UserId = user.UserId,
            FullName = user.FullName,
            MailAddress = user.Email,
            Section = user.Section == null
                ? null
                : new SectionResponse
                {
                    Name = user.Section.Name,
                    Department = user.Section.Department == null
                        ? null
                        : new DepartmentResponse
                        {
                            Name = user.Section.Department.Name
                        }
                }
        };
    }

    private static string BuildUserCacheKey(string userId)
        => $"{UserCachePrefix}{userId.ToUpperInvariant()}";

    private void CacheUser(UserResponse? user)
    {
        if (user == null || string.IsNullOrWhiteSpace(user.UserId))
            return;

        _cacheService.Set(BuildUserCacheKey(user.UserId), user, UserCacheDuration);
    }
}
