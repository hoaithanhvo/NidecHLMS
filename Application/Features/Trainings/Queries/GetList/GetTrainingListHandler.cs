using Application.Common.Paging;
using Application.DTOs.Responses.Trainings;
using Application.Features.Trainings.Queries.GetList;
using Application.Interfaces.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Trainings.Queries.Specs
{
	public class GetTrainingListQueryHandler
	: IRequestHandler<GetTrainingListQuery, PagedResult<TrainingListResponse>>
	{
		private readonly IGenericRepository<M_TRAINING_CONTENT, int> _repository;
		private readonly IMapper _mapper;

		public GetTrainingListQueryHandler(IGenericRepository<M_TRAINING_CONTENT, int> repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

        public async Task<PagedResult<TrainingListResponse>> Handle(
		GetTrainingListQuery request,
		CancellationToken cancellationToken)
		{
            var countSpec = new TrainingContentByKeywordSpec(request, false);
            var totalCount = await _repository.CountAsync(countSpec, cancellationToken);

            var listSpec = new TrainingContentByKeywordSpec(request, true);
            var items = await _repository.ToListAsync(listSpec, cancellationToken);

            return new PagedResult<TrainingListResponse>
            {
                Items = _mapper.Map<List<TrainingListResponse>>(items),
                PageIndex = request.PageIndex,
                PageSize = request.PageSize,
                TotalCount = totalCount
            };
        }
	}
}
