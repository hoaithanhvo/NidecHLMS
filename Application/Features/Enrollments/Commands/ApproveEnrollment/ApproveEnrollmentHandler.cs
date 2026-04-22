using Application.Interfaces.Repositories;
using Domain.Enrollment;
using Domain.Enrollment.Factories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Enrollments.Commands.ApproveEnrollment
{
	public class ApproveEnrollmentHandler
	: IRequestHandler<ApproveEnrollmentCommand, Unit>
	{
		private readonly IEnrollmentRepository _repo;
		private readonly IEnrollmentStateFactory _factory;

		public async Task<Unit> Handle(ApproveEnrollmentCommand request, CancellationToken ct)
		{
			var entity = await _repo.GetByIdAsync(request.Id);

			var context = new EnrollmentContext(
				entity,
				_factory.Create(entity.StatusId)
			);

			await context.ApproveAsync();

			await _repo.UpdateAsync(entity);

			return Unit.Value;
		}
	}
}
