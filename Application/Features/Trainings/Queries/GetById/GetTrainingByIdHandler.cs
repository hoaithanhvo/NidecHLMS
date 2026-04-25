using Application.Common.Exceptions;
using Application.DTOs.Responses.Trainings;
using Application.Features.Trainings.Queries.Specs;
using Application.Interfaces.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Trainings.Queries.GetById
{
	public class GetTrainingByIdHandler : IRequestHandler<GetTrainingByIdQuery, TrainingListResponse>
	{
		private readonly IGenericRepository<M_TRAINING_CONTENT, int> _repository;
		private readonly IMapper _mapper;
        public GetTrainingByIdHandler(
            IGenericRepository<M_TRAINING_CONTENT, int> repository,
            IMapper mapper
            )
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<TrainingListResponse> Handle(GetTrainingByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await _repository.GetAsync(
                new GetTrainningByIdSpec(request.Id), cancellationToken);

            if (entity == null)
                throw new NotFoundException(nameof(M_TRAINING_CONTENT), request.Id);

            return _mapper.Map<TrainingListResponse>(entity);
        }
    }
}
