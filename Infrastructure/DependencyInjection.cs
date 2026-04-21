using Application.Common.Interfaces;
using Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
	public static class DependencyInjection
	{
		public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddHttpClient();

			// Example services
			services.AddScoped(typeof(IQueryRepository<>), typeof(QueryRepository<>));
			services.AddScoped(typeof(ICommandRepository<>), typeof(CommandRepository<>));
			return services;
		}
	}
}
