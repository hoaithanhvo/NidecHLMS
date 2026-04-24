using Application.Interfaces.Repositories;
using AutoMapper;
using Domain.Enrollment;
using Domain.Enrollment.Factories;
using Domain.Entities;
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
		private readonly IGenericRepository<T_USER_TRAINING_ENROLLMENT, int> _repository;
		private readonly IMapper _mapper;
		private readonly IEnrollmentStateFactory _factory;

		public ApproveEnrollmentHandler(IGenericRepository<T_USER_TRAINING_ENROLLMENT, int> repository, IMapper mapper, IEnrollmentStateFactory factory)
		{
			_repository = repository;
			_mapper = mapper;
			_factory = factory;


		}
		public async Task<Unit> Handle(ApproveEnrollmentCommand request, CancellationToken ct)
		{
			
			var entity = await _repository.GetByIdAsync(request.Id);

			if(entity == null)
				throw new Exception("Enrollment not found");

			var context = new EnrollmentContext(
				entity,
				_factory.Create(entity.StatusId)
			);

			await context.ApproveAsync();

			entity.UpdatedDate = DateTime.UtcNow;
			entity.UpdatedBy = "B600044177"; 

			await _repository.UpdateAsync(entity);

			return Unit.Value;
		}
	}
}
