using Application.Interfaces.Repositories;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Trainings.Commands.Create
{
	public class CreateTrainingHandler : IRequestHandler<CreateTrainingCommand, int>
	{
		private readonly ICommandRepository<M_TRAINING_CONTENT, int> _repo;

		public CreateTrainingHandler(ICommandRepository<M_TRAINING_CONTENT, int> repo)
		{
			_repo = repo;
		}
		public async Task<int> Handle(CreateTrainingCommand request, CancellationToken cancellationToken)
		{
			var entity = new M_TRAINING_CONTENT
			{
				ManagementNumber = request.ManagementNumber,
				TrainingContentName = request.TrainingContentName,
				OperationId = request.OperationId,
				LifecycleId = request.LifecycleId,
				CreatedBy = request.CreatedBy,
				UpdatedBy = request.UpdatedBy,
				CreatedDate = DateTime.UtcNow,
				UpdatedDate = DateTime.UtcNow
			};

			await _repo.CreateAsync(entity, cancellationToken);

			return entity.Id;
		}
	}
}
