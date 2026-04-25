using Application.DTOs.Responses;
using Application.Interfaces.Services;
using Infrastructure.Models;
using Microsoft.Extensions.Configuration;
using NidecSystemShared.Common;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace Infrastructure.Services
{
    public class UserRestApiService : IUserRestApiService
    {
        private const string GetUserPath = "api/users/GetUserById";
        private const string GetUsersPath = "api/v1/users/GetUsersByIds";

        private readonly HttpClient _client;
        private readonly ITokenManager _tokenManager;

        public UserRestApiService(HttpClient client, ITokenManager tokenManager)
        {
            _client = client;
            _tokenManager = tokenManager;
        }


        public async Task<UserResponse> GetUser(string userId)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(userId);
            await AddTokenAsync();

            var url = $"{GetUserPath}?userId={Uri.EscapeDataString(userId)}";

            var response = await _client.GetAsync(url);

            if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                await _tokenManager.RefreshTokenAsync();
                await AddTokenAsync();
                response = await _client.GetAsync(url);
            }

            response.EnsureSuccessStatusCode();

            var user = await response.Content.ReadFromJsonAsync<UserResponse>();
            return user ?? throw new InvalidOperationException("User API returned an empty payload.");
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

            await AddTokenAsync();

            var query = string.Join("&", normalizedIds.Select(id => $"userIds={Uri.EscapeDataString(id)}"));
            var url = $"{GetUsersPath}?{query}";

            var response = await _client.GetAsync(url);

            if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                await _tokenManager.RefreshTokenAsync();
                await AddTokenAsync();
                response = await _client.GetAsync(url);
            }

            response.EnsureSuccessStatusCode();

            var apiResponse = await response.Content.ReadFromJsonAsync<ApiResponse<List<UserResponse>>>();

            return apiResponse?.Data ?? new List<UserResponse>();
        }


        private async Task AddTokenAsync()
        {
            var token = await _tokenManager.GetTokenAsync();

            _client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", token);
        }
    }

    public interface ITokenManager
    {
        Task<string> GetTokenAsync();
        Task<string> RefreshTokenAsync();
    }

    public class TokenManager : ITokenManager
    {
        private readonly HttpClient _client;
        private readonly IConfiguration _config;

        public TokenManager(HttpClient client, IConfiguration config)
        {
            _client = client;
            _config = config;
        }

        public async Task<string> GetTokenAsync()
        {
            var existing = TokenIDM.GetAccessToken();
            if (!string.IsNullOrEmpty(existing))
                return existing;

            return await RefreshTokenAsync();
        }

        public async Task<string> RefreshTokenAsync()
        {
            var baseUrl = RequireSetting("IDM:BaseUrl");
            var clientId = RequireSetting("IDM:ClientId");
            var clientSecret = RequireSetting("IDM:ClientSecret");
            var tokenEndpoint = RequireSetting("IDM:TokenEndpoint");
            var grantType = RequireSetting("IDM:GrantType");

            var tokenUrl = $"{baseUrl.TrimEnd('/')}/{tokenEndpoint.TrimStart('/')}";
            var request = new HttpRequestMessage(HttpMethod.Post, tokenUrl)
            {
                Content = new FormUrlEncodedContent(new Dictionary<string, string>
                {
                    { "client_id", clientId },
                    { "client_secret", clientSecret },
                    { "grant_type", grantType }
                })
            };

            var response = await _client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadFromJsonAsync<TokenResponse>()
                ?? throw new InvalidOperationException("Token endpoint returned an empty payload.");

            if (string.IsNullOrWhiteSpace(result.access_token))
                throw new InvalidOperationException("Token endpoint returned an empty access token.");

            TokenIDM.SetAccessToken(result.access_token);

            return result.access_token;
        }

        private string RequireSetting(string key)
        {
            return _config[key]
                ?? throw new InvalidOperationException($"Missing configuration value: '{key}'.");
        }

        private sealed class TokenResponse
        {
            public string access_token { get; set; } = string.Empty;
            public int expires_in { get; set; }
            public string token_type { get; set; } = string.Empty;
        }
    }
}
