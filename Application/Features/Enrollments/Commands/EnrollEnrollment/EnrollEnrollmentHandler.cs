using Application.Interfaces.Repositories;
using Domain.Enrollment;
using Domain.Enrollment.Factories;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Enrollments.Commands.EnrollEnrollment
{
	public class EnrollEnrollmentHandler
		: IRequestHandler<EnrollEnrollmentCommand, Unit>
	{
		private readonly IGenericRepository<T_USER_TRAINING_ENROLLMENT, int> _repository;
		private readonly IEnrollmentStateFactory _factory;

		public EnrollEnrollmentHandler(
			IGenericRepository<T_USER_TRAINING_ENROLLMENT, int> repository,
			IEnrollmentStateFactory factory)
		{
			_repository = repository;
			_factory = factory;
		}

		public async Task<Unit> Handle(EnrollEnrollmentCommand request, CancellationToken ct)
		{
			var entity = await _repository.GetByIdAsync(request.Id);

			if(entity == null)
				throw new Exception("Enrollment not found");

			var context = new EnrollmentContext(entity,_factory.Create(entity.StatusId)
			);

			await context.EnrollAsync();

			entity.UpdatedDate = DateTime.Now;
			entity.UpdatedBy = "B600044177";

			await _repository.UpdateAsync(entity);

			return Unit.Value;
		}
	}
}
