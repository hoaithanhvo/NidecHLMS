using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Context
{
	public interface IReadDbContext
	{
		/// <summary>
		/// The CreateConnection
		/// </summary>
		/// <returns>The <see cref="IDbConnection"/></returns>
		IDbConnection CreateConnection();
	}
}
