using Application.Interfaces.Repositories;
using Domain.Entities;
using Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Enrollments.Commands.RegisterEnrollment
{
	public class RegisterEnrollmentHandler
	: IRequestHandler<RegisterEnrollmentCommand, int>
	{
		private readonly IEnrollmentRepository _repo;
		public RegisterEnrollmentHandler(IEnrollmentRepository repo)
		{
			_repo = repo;
		}

		public async Task<int> Handle(RegisterEnrollmentCommand request, CancellationToken ct)
		{
			var entity = new T_USER_TRAINING_ENROLLMENT
			{
				ParticipantId = request.ParticipantId,
				TrainingContentId = request.TrainingContentId,
				TrainingContentFlowId = request.TrainingContentFlowId,
				EnrollmentCode = request.EnrollmentCode,
				StatusId = (int)EnrollmentStatus.Resign,
				CreatedBy = "B600044177",
				UpdatedBy = "B600044177",
				CreatedDate = DateTime.Now,
				UpdatedDate = DateTime.Now,	
			};

			await _repo.AddAsync(entity);

			return entity.Id;
		}
	}
}
