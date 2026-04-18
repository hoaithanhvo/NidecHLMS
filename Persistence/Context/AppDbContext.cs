using Application.Interfaces.Persistence;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Persistence.Context
{
	public class AppDbContext : DbContext, IApplicationDbContext
    {
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<LOG_AUDIT> AuditLogs => Set<LOG_AUDIT>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
		}
	}
}
