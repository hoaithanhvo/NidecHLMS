using Application.Common.Exceptions;
using Application.Interfaces.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.Features.Trainings.Commands.Delete
{
    public class DeleteTrainingHandler : IRequestHandler<DeleteTrainingCommand, bool>
    {
        private readonly IGenericRepository<M_TRAINING_CONTENT, int> _repository;

        public DeleteTrainingHandler(IGenericRepository<M_TRAINING_CONTENT, int> repository)
        {
            _repository = repository;
        }

        public async Task<bool> Handle(DeleteTrainingCommand request, CancellationToken cancellationToken)
        {
            var entity = await _repository.GetByIdAsync(request.Id, cancellationToken);
            if (entity == null)
                throw new NotFoundException(nameof(M_TRAINING_CONTENT), request.Id);

            await _repository.DeleteAsync(entity, cancellationToken);
            return true;
        }
    }
}
