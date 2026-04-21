using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models
{
	public static class TokenIDM
	{
		private static string? _accessToken;
		private static readonly object _lock = new object();

		public static string? GetAccessToken()
		{
			lock(_lock)
			{
				return _accessToken;
			}
		}

		public static void SetAccessToken(string accessToken)
		{
			lock(_lock)
			{
				_accessToken = accessToken;
			}
		}
	}
}
