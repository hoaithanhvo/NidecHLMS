using Application.Common.Interfaces;
using Application.Common.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static Dapper.SqlMapper;

namespace Infrastructure.Repositories
{
	public class QueryRepository<TEntity> : IQueryRepository<TEntity>
	where TEntity : class
	{
		private readonly AppDbContext _context;

		public QueryRepository(AppDbContext context)
		{
			_context = context;
		}

		public async Task<TEntity?> GetByIdAsync(int id)
		{
			return await _context.Set<TEntity>().FindAsync(id);
		}

		public async Task<List<TEntity>> GetListAsync()
		{
			return await _context.Set<TEntity>().ToListAsync();
		}

		public async Task<PagedResult<TEntity>> GetPagedAsync(
			Expression<Func<TEntity, bool>>? predicate,
			int pageIndex,
			int pageSize)
		{
			var query = _context.Set<TEntity>().AsQueryable();

			if(predicate != null)
				query = query.Where(predicate);

			var totalCount = await query.CountAsync();

			var items = await query
				.Skip(pageIndex * pageSize)
				.Take(pageSize)
				.ToListAsync();

			return new PagedResult<TEntity>
			{
				Items = items,
				PageIndex = pageIndex,
				PageSize = pageSize,
				TotalCount = totalCount
			};
		}
	}
}
