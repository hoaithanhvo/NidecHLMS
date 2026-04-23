using Application.Common.DTOs;
using Application.DTOs.Responses.Enrollments;
using Application.Interfaces.Repositories;
using AutoMapper;
using Domain.Entities;
using Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Enrollments.Commands.RegisterEnrollment
{
	public class SubmitEnrollmentHandler
	: IRequestHandler<SubmitEnrollmentCommand, RegisterEnrollmentResponse>
	{
		private readonly IMapper _mapper;
		private readonly IUnitOfWork _unitOfWork;

		public SubmitEnrollmentHandler(IUnitOfWork unitOfWork, IMapper mapper)
		{
			_mapper = mapper;
			_unitOfWork = unitOfWork;

		}

		public async Task<RegisterEnrollmentResponse> Handle(SubmitEnrollmentCommand request, CancellationToken ct)
		{
			var enrollmentRepo = _unitOfWork.GenericRepository<T_USER_TRAINING_ENROLLMENT, int>();

			// 1. Map Enrollment (Parent)
			var enrollment = _mapper.Map<T_USER_TRAINING_ENROLLMENT>(request);

			enrollment.StatusId = (int)EnrollmentStatus.Submitted;
			enrollment.CreatedBy = "B600044177";
			enrollment.CreatedDate = DateTime.Now;
			enrollment.UpdatedBy = "B600044177";
			enrollment.UpdatedDate = DateTime.Now;

			// 2. Create Progress (Child - attach vào navigation)
			enrollment.T_UserTrainingProgress = new List<T_USER_TRAINING_PROGRESS>
			{
				new T_USER_TRAINING_PROGRESS
				{
					StatusId = (int)EnrollmentStatus.Submitted,
					ActionDate = DateTime.UtcNow,
					TrainingContentFlowStepId = 6,
					CreatedBy = enrollment.CreatedBy,
					CreatedDate = DateTime.UtcNow,
					UpdatedBy = enrollment.UpdatedBy,
					UpdatedDate	= DateTime.UtcNow,
				}
			};

			// 3. ONLY ONE CALL → EF handles both tables
			await enrollmentRepo.CreateAsync(enrollment, ct);

			// 4. TransactionBehavior sẽ tự:
			//    - BeginTransaction
			//    - SaveChanges (1 lần)
			//    - Commit
			//    - Audit saves
			//    - Rollback nếu lỗi

			return _mapper.Map<RegisterEnrollmentResponse>(enrollment);
		}
	}
}
