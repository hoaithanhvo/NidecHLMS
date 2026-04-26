using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Exceptions
{
	public class BusinessException : AppException
	{

		/// <summary>
		/// 400 — Business logic exception
		/// throw new BusinessException
		/// </summary>
		public BusinessException(string message) : base(message)
		{

		}
	}
}
