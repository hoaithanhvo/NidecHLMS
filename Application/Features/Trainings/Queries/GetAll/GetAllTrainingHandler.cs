using Application.Common.Paging;
using Application.DTOs.Responses.Trainings;
using Application.Features.Trainings.Queries.Specs;
using Application.Interfaces.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Trainings.Queries.GetAll
{
    public class GetAllTrainingHandler : IRequestHandler<GetAllTrainingQuery, PagedResult<TrainingListResponse>>
    {
        private readonly IGenericRepository<M_TRAINING_CONTENT, int> _repository;
        private readonly IMapper _mapper;

        public GetAllTrainingHandler(IGenericRepository<M_TRAINING_CONTENT, int> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<PagedResult<TrainingListResponse>> Handle(GetAllTrainingQuery request, CancellationToken cancellationToken)
        {
            var countSpec = new GetAllTrainingContentSpec(request, false);
            var totalCount = await _repository.CountAsync(countSpec, cancellationToken);

            var listSpec = new GetAllTrainingContentSpec(request, true);
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
