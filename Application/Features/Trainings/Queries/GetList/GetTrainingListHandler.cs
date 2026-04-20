using Application.Common.Interfaces;
using Application.Common.Paging;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Trainings.Queries.GetList
{
	public class GetTrainingListQueryHandler
	: IRequestHandler<GetTrainingListQuery, PagedResult<TrainingContentDto>>
	{
		private readonly IQueryRepository<M_TRAINING_CONTENT> _repository;
		private readonly IMapper _mapper;

		public GetTrainingListQueryHandler(IQueryRepository<M_TRAINING_CONTENT> repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		public async Task<PagedResult<TrainingContentDto>> Handle(
		GetTrainingListQuery request,
		CancellationToken cancellationToken)
		{
			try
			{
				var (items, totalCount, pageIndex, pageSize) = await _repository.GetPagedAsync(
				x =>
					(string.IsNullOrEmpty(request.Keyword) ||
					 x.TrainingContentName.Contains(request.Keyword) ||
					 x.ManagementNumber.Contains(request.Keyword)),
				request.PageIndex,
				request.PageSize);

				var map = _mapper.Map<List<TrainingContentDto>>(items);

				return new PagedResult<TrainingContentDto>
				{
					Items = map,
					PageIndex = request.PageIndex,
					PageSize = request.PageSize,
					TotalCount = totalCount
				};
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return null;
			}
		}
	}
}
