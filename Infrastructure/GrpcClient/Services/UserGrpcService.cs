using Application.DTOs.UserDTO.Responses;
using Application.Interfaces.Services;
using Infrastructure.GrpcClient.ProtosFile;

namespace Infrastructure.GrpcClient.Services;

public class UserGrpcService : IUserGrpcService
{
    private readonly ServiceGetUser.ServiceGetUserClient _serviceClient;

    public UserGrpcService(ServiceGetUser.ServiceGetUserClient serviceClient)
    {
        _serviceClient = serviceClient;
    }

    public async Task<UserResponse> GetUser(string userId)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(userId);

        var user = await _serviceClient.GetUserByUserIdAsync(new UserIdRequest { UserId = userId });

        return MapUser(user);
    }

    public async Task<List<UserResponse>> GetUsers(List<string> userIds)
    {
        ArgumentNullException.ThrowIfNull(userIds);

        var request = new UserIdsRequest();
        request.UserIds.Add(userIds.Where(x => !string.IsNullOrWhiteSpace(x)));

        if (request.UserIds.Count == 0)
            return [];

        var users = await _serviceClient.GetUsersByUserIdsAsync(request);
        return users.Users.Select(MapUser).ToList();
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
}
