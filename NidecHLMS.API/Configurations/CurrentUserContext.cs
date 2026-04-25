using Application.Interfaces.Common;
using System.Security.Claims;

namespace NidecHLMS.API.Configurations;

public class CurrentUserContext : ICurrentUserContext
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    public CurrentUserContext(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public string? UserId =>
     _httpContextAccessor.HttpContext?.User?
         .FindFirst(ClaimTypes.NameIdentifier)?.Value
     ?? _httpContextAccessor.HttpContext?.User?
         .FindFirst("sub")?.Value
     ?? _httpContextAccessor.HttpContext?.User?
         .FindFirst("userId")?.Value
     ?? "1479"; 

    public bool IsAuthenticated =>
        _httpContextAccessor.HttpContext?.User?.Identity?.IsAuthenticated ?? false;

    public string? RequestPath
    {
        get
        {
            var httpContext = _httpContextAccessor.HttpContext;
            if (httpContext == null)
                return null;

            var rawPath = httpContext.Request.Path.Value;
            return string.IsNullOrWhiteSpace(rawPath) ? null : rawPath;
        }
    }
}
