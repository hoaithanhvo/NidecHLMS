using Application.DTOs.Responses.Enrollments;
using Application.Interfaces.Repositories;
using Application.Interfaces.Services;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Enrollments.Commands.ExecuteEnrollment
{
	public class ExecuteEnrollmentActionHandler
		: IRequestHandler<ExecuteEnrollmentActionCommand, ExecuteEnrollmentActionResponse>
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IWorkflowService _workflow;

		public ExecuteEnrollmentActionHandler(
			IUnitOfWork unitOfWork,
			IWorkflowService workflow)
		{
			_unitOfWork = unitOfWork;
			_workflow = workflow;
		}

		public async Task<ExecuteEnrollmentActionResponse> Handle(
			ExecuteEnrollmentActionCommand request,
			CancellationToken ct)
		{
			var repo = _unitOfWork
				.GenericRepository<T_USER_TRAINING_ENROLLMENT, int>();

			// =====================================================
			// 1. LOAD ENTITY (with progress history)
			// =====================================================
			var entity = await repo.GetAsync(
				new EnrollmentWithProgressSpec(request.EnrollmentId),
				ct);

			if(entity == null)
				throw new Exception("Enrollment not found");

			if(entity.T_UserTrainingProgress == null)
				throw new Exception("Progress not initialized");

			var fromStepId = entity.TrainingContentStepId;

			// =====================================================
			// 2. EXECUTE WORKFLOW ENGINE (DB-driven)
			// =====================================================
			await _workflow.ExecuteAsync(entity, request.ActionCode, ct);

			var toStepId = entity.TrainingContentStepId;

			// =====================================================
			// 3. CREATE PROGRESS LOG (audit trail)
			// =====================================================
			entity.T_UserTrainingProgress.Add(new T_USER_TRAINING_PROGRESS
			{
				UserTrainingEnrollmentId = entity.Id,
				TrainingContentStepId = toStepId,
				StatusId = entity.StatusId,
				ActionDate = DateTime.UtcNow,
				CreatedBy = entity.UpdatedBy,
				CreatedDate = DateTime.UtcNow,
				UpdatedBy = entity.UpdatedBy,
				UpdatedDate = DateTime.UtcNow
			});

			// =====================================================
			// 4. OPTIONAL: UPDATE STATUS BY STEP
			// =====================================================
			entity.StatusId = MapStepToStatus(toStepId);

			entity.UpdatedDate = DateTime.UtcNow;
			entity.UpdatedBy = "SYSTEM"; // replace IUserContext

			// =====================================================
			// 5. SAVE (UnitOfWork handles transaction)
			// =====================================================
			await repo.UpdateAsync(entity, ct);

			// =====================================================
			// 6. RESPONSE
			// =====================================================
			return new ExecuteEnrollmentActionResponse
			{
				EnrollmentId = entity.Id,
				FromStepId = fromStepId,
				ToStepId = toStepId,
				ActionCode = request.ActionCode,
				ExecutedAt = DateTime.UtcNow,
				Success = true
			};
		}

		// =========================================================
		// Step → Status mapping (có thể nâng cấp thành DB table)
		// =========================================================
		private int MapStepToStatus(int stepId)
		{
			return stepId switch
			{
				1 => 17, // Submitted
				2 => 21, // InProgress
				3 => 22, // Completed
				4 => 23, // Cancelled
				_ => 17
			};
		}
	}
}
