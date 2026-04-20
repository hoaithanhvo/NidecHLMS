using Application.Common.Paging;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
	public interface IQueryRepository<TEntity>
	{
		Task<TEntity?> GetByIdAsync(int id);

		Task<List<TEntity>> GetListAsync();

		Task<PagedResult<TEntity>> GetPagedAsync(
			Expression<Func<TEntity, bool>>? predicate,
			int pageIndex,
			int pageSize);
	}
}
