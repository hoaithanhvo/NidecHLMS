using Application.Common.Paging;
using Application.Interfaces.Repositories;
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
		private readonly IGenericRepository<M_TRAINING_CONTENT, int> _repository;
		private readonly IMapper _mapper;

		public GetTrainingListQueryHandler(IGenericRepository<M_TRAINING_CONTENT, int> repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

        public async Task<PagedResult<TrainingContentDto>> Handle(
		GetTrainingListQuery request,
		CancellationToken cancellationToken)
		{
            var trainningContentSpec = new TrainingContentListSpecification(request);

            var items = await _repository.ToListAsync(trainningContentSpec, cancellationToken);
            var totalCount = await _repository.CountAsync(trainningContentSpec, cancellationToken);

            return new PagedResult<TrainingContentDto>
            {
                Items = _mapper.Map<List<TrainingContentDto>>(items),
                PageIndex = request.PageIndex,
                PageSize = request.PageSize,
                TotalCount = totalCount
            };
        }
	}
}
