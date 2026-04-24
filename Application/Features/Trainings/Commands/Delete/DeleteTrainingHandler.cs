using Application.Common.Exceptions;
using Application.Features.Trainings.Queries.Specs;
using Application.Interfaces.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.Features.Trainings.Commands.Delete
{
    public class DeleteTrainingHandler : IRequestHandler<DeleteTrainingCommand, bool>
    {
        private readonly IGenericRepository<M_TRAINING_CONTENT, int> _repository;
        private readonly IGenericRepository<M_STATUS, int> _statusRepository;

        public DeleteTrainingHandler(IGenericRepository<M_TRAINING_CONTENT, int> repository,
            IGenericRepository<M_STATUS, int> statusRepository)
        {
            _repository = repository;
            _statusRepository = statusRepository;
        }

        public async Task<bool> Handle(DeleteTrainingCommand request, CancellationToken cancellationToken)
        {
            var entity = await _repository.GetByIdAsync(request.Id, cancellationToken);
            if (entity == null)
                throw new NotFoundException(nameof(M_TRAINING_CONTENT), request.Id);

            var deleteStatus = await _statusRepository.GetAsync(
                new TrainingStatusSpec(type: "root", statusName: "DELETE"), cancellationToken);

            if (deleteStatus == null)
                throw new NotFoundException("Can not find Status", 0);

            await _repository.ChangeStatusAsync(entity, deleteStatus.Id, cancellationToken);

            return true;
        }
    }
}
