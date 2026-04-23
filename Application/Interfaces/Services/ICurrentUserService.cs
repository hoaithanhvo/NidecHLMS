using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Services
{
	public interface ICurrentUserService
	{
		/// <summary>
		/// Gets the GetUserId
		/// </summary>
		string GetUserId { get; }

		/// <summary>
		/// Gets a value indicating whether IsAuthen
		/// </summary>
		bool IsAuthen { get; }
	}
}
