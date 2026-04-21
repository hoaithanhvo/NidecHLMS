﻿using Application.DTOs.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Services
{
    public interface IUserGrpcService
    {
        Task<UserResponse> GetUser(string userId);
        Task<List<UserResponse>> GetUsers(List<string> userIds);
    }
}
