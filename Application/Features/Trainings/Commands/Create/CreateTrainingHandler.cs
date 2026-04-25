using Application.Common.Exceptions;
using Application.Features.Trainings.Queries.Specs;
using Application.Interfaces.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.Features.Trainings.Commands.Create
{
	public class CreateTrainingHandler : IRequestHandler<CreateTrainingCommand, bool>
	{
		private readonly IGenericRepository<M_TRAINING_CONTENT, int> _trainingRepository;
		private readonly IGenericRepository<M_STATUS, int> _statusRepository;

		public CreateTrainingHandler(
            IGenericRepository<M_TRAINING_CONTENT, int> trainingRepository,
            IGenericRepository<M_STATUS, int> statusRepository)
		{
			_trainingRepository = trainingRepository;
			_statusRepository = statusRepository;
		}

		public async Task<bool> Handle(CreateTrainingCommand request, CancellationToken cancellationToken)
		{
			var rootStatus = await _statusRepository.GetAsync(
				new TrainingStatusSpec(
					type: "root",
					statusName: "ACTIVE"),
				cancellationToken);

			if (rootStatus == null)
				throw new NotFoundException("Cannot find Status", 0);

			var entity = new M_TRAINING_CONTENT
			{
				ManagementNumber = request.ManagementNumber,
				TrainingContentName = request.TrainingContentName,
				OperationId = request.OperationId,
				LifecycleId = request.LifecycleId,
				StatusId = rootStatus.Id
			};

			await _trainingRepository.CreateAsync(entity, cancellationToken);
			return true;
		}

	}
}
