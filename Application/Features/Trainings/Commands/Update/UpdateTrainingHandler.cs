using Application.Common.Exceptions;
using Application.Features.Trainings.Queries.Specs;
using Application.Interfaces.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.Features.Trainings.Commands.Update
{
    public class UpdateTrainingHandler : IRequestHandler<UpdateTrainingCommand, bool>
    {
        private readonly IGenericRepository<M_TRAINING_CONTENT, int> _repository;
        private readonly IGenericRepository<M_STATUS, int> _statusRepository;

        public UpdateTrainingHandler(
            IGenericRepository<M_TRAINING_CONTENT, int> repository,
            IGenericRepository<M_STATUS, int> statusRepository)
        {
            _repository = repository;
            _statusRepository = statusRepository;
        }

        public async Task<bool> Handle(UpdateTrainingCommand request, CancellationToken cancellationToken)
        {
            var entity = await _repository.GetByIdAsync(request.Id, cancellationToken);
            if (entity == null)
                throw new NotFoundException(nameof(M_TRAINING_CONTENT), request.Id);

            entity.ManagementNumber = request.ManagementNumber;
            entity.TrainingContentName = request.TrainingContentName;
            entity.OperationId = request.OperationId;
            entity.LifecycleId = request.LifecycleId;

            if (entity.StatusId <= 0)
            {
                var rootStatus = await _statusRepository.GetAsync(
                    new TrainingStatusSpec(
                        type: "root",
                        statusName: "ACTIVE"),
                    cancellationToken);
                if (rootStatus == null)
                    throw new NotFoundException("Cannot find status", 0);

                entity.StatusId = rootStatus.Id;
            }

            await _repository.UpdateAsync(entity, cancellationToken);
            return true;
        }
    }
}
