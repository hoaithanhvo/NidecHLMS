using Application.DTOs.Responses;
using Application.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.GrpcClient.Services
{
	//internal class UserGrpcService : IUserGrpcService
	//{
	//	private readonly ServiceGetUser.ServiceGetUserClient _serviceClient;

	//	public UserGrpcService(ServiceGetUser.ServiceGetUserClient serviceClient)
	//	{
	//		_serviceClient = serviceClient;
	//	}

	//	public async Task<UserResponse> GetUser(string userId)
	//	{
	//		var user = await _serviceClient.GetUserByUserIdAsync(new UserIdRequest() { UserId = userId });

	//		UserResponse userResponse = new UserResponse
	//		{
	//			UserId = user.UserId,
	//			FullName = user.FullName,
	//			MailAddress = user.Email,
	//			Section = new SectionResponse
	//			{
	//				Name = user.Section.Name,
	//				Department = new DepartmentResponse
	//				{
	//					Name = user.Section.Department.Name,
	//				}
	//			}
	//		};

	//		return userResponse;
	//	}

	//	public async Task<List<UserResponse>> GetUsers(List<string> userIds)
	//	{
	//		var request = new UserIdsRequest();
	//		request.UserIds.Add(userIds);
	//		var users = await _serviceClient.GetUsersByUserIdsAsync(request);

	//		var listUserResponses = new List<UserResponse>();
	//		foreach(var user in users.Users)
	//		{
	//			UserResponse userResponse = new UserResponse
	//			{
	//				UserId = user.UserId,
	//				FullName = user.FullName,
	//				MailAddress = user.Email,
	//				Section = new SectionResponse
	//				{
	//					Name = user.Section.Name,
	//					Department = new DepartmentResponse
	//					{
	//						Name = user.Section.Department.Name,
	//					}
	//				}
	//			};

	//			listUserResponses.Add(userResponse);
	//		}

	//		return listUserResponses;
	//	}
	//}
}
