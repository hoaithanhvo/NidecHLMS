using Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
	public class CommandRepository<TEntity> : ICommandRepository<TEntity>
		where TEntity : class
	{
		private readonly AppDbContext _context;
		private readonly DbSet<TEntity> _dbSet;

		public CommandRepository(AppDbContext context)
		{
			_context = context;
			_dbSet = _context.Set<TEntity>();
		}

		public async Task AddAsync(TEntity entity)
		{
			await _dbSet.AddAsync(entity);
		}

		public Task UpdateAsync(TEntity entity)
		{
			_dbSet.Update(entity);
			return Task.CompletedTask;
		}

		public Task DeleteAsync(TEntity entity)
		{
			_dbSet.Remove(entity);
			return Task.CompletedTask;
		}
	}
}
