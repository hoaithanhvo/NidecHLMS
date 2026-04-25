using Application.Common.DTOs;
using Application.Features.Trainings.Queries.GetById;
using Application.Interfaces.Repositories;
using Application.Interfaces.Services;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.WorkflowAction.Queries.GetAvailable
{
	public class GetAvailableActionsHandler : IRequestHandler<GetAvailableActionsQuery, List<WorkflowActionDTO>>
	{
		private readonly IWorkflowService _workflowService;
		private readonly IGenericRepository<T_USER_TRAINING_ENROLLMENT, int> _enrollmentRepo;

		public GetAvailableActionsHandler(
		IWorkflowService workflowService,
		IGenericRepository<T_USER_TRAINING_ENROLLMENT, int> enrollmentRepo)
		{
			_workflowService = workflowService;
			_enrollmentRepo = enrollmentRepo;
		}
		public async Task<List<WorkflowActionDTO>> Handle(GetAvailableActionsQuery request, CancellationToken ct)
		{
			// 1. load enrollment + progress
			var enrollment = await _enrollmentRepo.GetAsync(
				new GetEnrollmentWithProgressSpec(request.EnrollmentId),
				ct);

			if(enrollment == null)
				throw new Exception("Enrollment not found");

			// 2. lấy available actions từ workflow
			var actions = await _workflowService.GetAvailableActionsAsync(enrollment, ct);

			// 3. map DTO
			return actions
				.Select(x => new WorkflowActionDTO
				{
					ActionId = x.ActionId,
					ActionCode = x.ActionCode,
					ActionName = x.ActionName,
					Direction = x.Direction
				})
				.ToList();
		}
	}
}
