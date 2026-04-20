using Application.Common.Paging;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Queries.Paging
{
	public class GetPagedQuery<TEntity, TDto>: IRequest<PagedResult<TDto>>
	{
		public Expression<Func<TEntity, bool>>? Predicate { get; set; }
		public int PageIndex { get; set; }
		public int PageSize { get; set; }
	}
}
