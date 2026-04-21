using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models
{
	public class JwtOption
	{
		/// <summary>
		/// Gets or sets the SecretKey
		/// </summary>
		public string? SecretKey { get; set; }

		/// <summary>
		/// Gets or sets the Issuer
		/// </summary>
		public string? Issuer { get; set; }

		/// <summary>
		/// Gets or sets the Audience
		/// </summary>
		public string? Audience { get; set; }
	}
}
