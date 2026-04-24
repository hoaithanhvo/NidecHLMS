using Application.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
	public class CurrentUserService : ICurrentUserService
	{
		/// <summary>
		/// Defines the _httpContextAccessor
		/// </summary>
		private readonly IHttpContextAccessor _httpContextAccessor;

		/// <summary>
		/// Defines the _currentUser
		/// </summary>
		private string _currentUser = "";

		/// <summary>
		/// Initializes a new instance of the <see cref="CurrentUserService"/> class.
		/// </summary>
		/// <param name="httpContextAccessor">The httpContextAccessor<see cref="IHttpContextAccessor"/></param>
		public CurrentUserService(IHttpContextAccessor httpContextAccessor)
		{
			_httpContextAccessor = httpContextAccessor ?? throw new ArgumentNullException(nameof(httpContextAccessor));
		}

		/// <summary>
		/// Gets the GetUserId
		/// </summary>
		public string GetUserId
		{
			get
			{
				if(string.IsNullOrEmpty(_currentUser))
				{
					_currentUser = MapFromHttpContext(_httpContextAccessor.HttpContext);
				}
				return _currentUser;
			}
		}

		/// <summary>
		/// Gets a value indicating whether IsAuthen
		/// </summary>
		public bool IsAuthen
		{
			get
			{
				if(_httpContextAccessor.HttpContext == null || _httpContextAccessor.HttpContext.User == null || _httpContextAccessor.HttpContext.User.Identity == null)
				{
					return false;
				}

				return _httpContextAccessor.HttpContext.User.Identity.IsAuthenticated;
			}
		}

		/// <summary>
		/// The MapFromHttpContext
		/// </summary>
		/// <param name="httpContext">The httpContext<see cref="HttpContext"/></param>
		/// <returns>The <see cref="string"/></returns>
		private string MapFromHttpContext(HttpContext httpContext)
		{
			if(httpContext.User.Identity?.IsAuthenticated == true)
			{
				// Assuming the user ID is stored in a claim named "UserId"
				var userIdClaim = httpContext.User.FindFirst(ClaimTypes.NameIdentifier);
				if(userIdClaim != null)
				{
					return userIdClaim.Value.ToString();
				}
			}
			return "HLMS"; // or throw an exception, or return a default value
		}
	}
}
