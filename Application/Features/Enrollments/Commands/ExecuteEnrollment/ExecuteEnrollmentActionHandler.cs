using Application.Common.DTOs;
using Application.DTOs.Responses.Enrollments;
using Application.Interfaces.Repositories;
using Application.Interfaces.Services;
using AutoMapper;
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
		private readonly IMapper _mapper;

		public ExecuteEnrollmentActionHandler(
			IUnitOfWork unitOfWork,
			IWorkflowService workflow,IMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_workflow = workflow;
			_mapper = mapper;
		}

		public async Task<ExecuteEnrollmentActionResponse> Handle(
			ExecuteEnrollmentActionCommand request,
			CancellationToken ct)
		{
			var repo = _unitOfWork
				.GenericRepository<T_USER_TRAINING_ENROLLMENT, int>();

			// 1. LOAD ENTITY (with progress history)
			var enrollmentCurrent = await repo.GetAsync(
				new EnrollmentWithProgressSpec(request.EnrollmentId),
				ct);

			if(enrollmentCurrent == null)
				throw new Exception("Enrollment not found");

			if(enrollmentCurrent.T_UserTrainingProgress == null)
				throw new Exception("Progress not initialized");

			var fromStepId = enrollmentCurrent.TrainingContentStepId;

			// 2. EXECUTE WORKFLOW ENGINE (DB-driven)
			await _workflow.ExecuteAsync(enrollmentCurrent, request.ActionCode, ct);

			var toStepId = enrollmentCurrent.TrainingContentStepId;

			// 3. SAVE (UnitOfWork handles transaction)
			await repo.UpdateAsync(enrollmentCurrent, ct);

			// 4. RESPONSE
			return new ExecuteEnrollmentActionResponse
			{
				EnrollmentId = enrollmentCurrent.Id,
				FromStepId = fromStepId,
				ToStepId = toStepId,
				ActionCode = request.ActionCode,
				StatusId = _mapper.Map<StatusDTO>(enrollmentCurrent.M_Status)
			};
		}
	}
}
