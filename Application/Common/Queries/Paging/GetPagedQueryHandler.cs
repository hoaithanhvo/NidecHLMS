using Application.Common.Interfaces;
using Application.Common.Paging;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Queries.Paging
{
	public class GetPagedQueryHandler<TEntity, TDto>
	: IRequestHandler<GetPagedQuery<TEntity, TDto>, PagedResult<TDto>>
	{
		private readonly IQueryRepository<TEntity> _repo;
		private readonly IMapper _mapper;

		public GetPagedQueryHandler(IQueryRepository<TEntity> repo, IMapper mapper)
		{
			_repo = repo;
			_mapper = mapper;
		}

		public async Task<PagedResult<TDto>> Handle(
			GetPagedQuery<TEntity, TDto> request,
			CancellationToken cancellationToken)
		{
			var result = await _repo.GetPagedAsync(
				request.Predicate,
				request.PageIndex,
				request.PageSize);

			return new PagedResult<TDto>
			{
				Items = _mapper.Map<List<TDto>>(result.Items),
				PageIndex = result.PageIndex,
				PageSize = result.PageSize,
				TotalCount = result.TotalCount
			};
		}
	}
}
