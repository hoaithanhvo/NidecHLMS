using Application.Common.Interfaces;
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
		private readonly ICommandRepository<M_TRAINING_CONTENT> _repo;

		public CreateTrainingHandler(ICommandRepository<M_TRAINING_CONTENT> repo)
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
				CreatedDate = DateTime.UtcNow,
				UpdatedDate = DateTime.UtcNow
			};

			await _repo.AddAsync(entity);

			return entity.Id;
		}
	}
}
