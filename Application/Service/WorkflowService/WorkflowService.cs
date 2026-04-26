using Application.Common.DTOs;
using Application.Common.Exceptions;
using Application.Features.Enrollments.Commands.ExecuteEnrollment;
using Application.Features.Trainings.Queries.GetTransittion;
using Application.Interfaces.Repositories;
using Application.Interfaces.Services;
using AutoMapper;
using Domain.Entities;
using Domain.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service.WorkflowService
{
	public class WorkflowService : IWorkflowService
	{
		private readonly IGenericRepository<M_TRAINING_CONTENT_STEP_TRANSITION, int> _transitionRepo;
		private readonly IGenericRepository<M_TRAINING_CONTENT_FLOW_STEP, int> _flowStepRepo;
		private readonly IMapper _mapper;

		public WorkflowService(IGenericRepository<M_TRAINING_CONTENT_FLOW_STEP, int> flowstepRepo,
			IGenericRepository<M_TRAINING_CONTENT_STEP_TRANSITION, int> transitionRepo,
			IGenericRepository<M_TRAINING_CONTENT_FLOW_STEP, int> flowStepRepo,IMapper mapper)
		{
			_transitionRepo = transitionRepo;
			_flowStepRepo = flowStepRepo;
			_mapper = mapper;
		}

		// =========================================================
		// 🔥 1. INITIALIZE (Submit)
		// =========================================================
		public async Task InitializeAsync(
			T_USER_TRAINING_ENROLLMENT entity,
			CancellationToken ct)
		{
			// Get first step
			var firstStep = (await _flowStepRepo.ToListAsync(
				new FirstFlowStepSpec(entity.TrainingContentFlowId), ct))
				.OrderBy(x => x.OrderNo)
				.FirstOrDefault();

			// Get Stautus of first step.
			var fisrtStatus = await _transitionRepo.GetAsync(new EnrollmentWithTransitionSpec(firstStep.TrainingContentStep));

			if(firstStep == null)
				throw new Exception("Flow has no steps");

			// Set current step
			entity.TrainingContentFlowStepId = firstStep.Id;
			entity.TrainingContentStepId = firstStep.TrainingContentStepId;
			entity.StatusId = fisrtStatus.StatusId;

			// Create first progress
			entity.T_UserTrainingProgress = new List<T_USER_TRAINING_PROGRESS>
			{
				new T_USER_TRAINING_PROGRESS
				{
					TrainingContentStepId = firstStep.TrainingContentStepId,
					StatusId =  fisrtStatus.StatusId
				}
			};
		}

		// =========================================================
		// 🔥 2. EXECUTE (Approve / Next / Complete...)
		// =========================================================
		public async Task ExecuteAsync(
			T_USER_TRAINING_ENROLLMENT entity,
			int actionCode,
			CancellationToken ct)
		{
			var currentFlowStep = await _flowStepRepo.GetByIdAsync(entity.TrainingContentFlowStepId, ct);

			var currentStepId = currentFlowStep.TrainingContentStepId;

			// 2. tìm transition
			var specTransition = new TransitionSpec(
				currentStepId,
				actionCode,
				entity.TrainingContentFlowId);

			var transition = await _transitionRepo.GetAsync(specTransition, ct);

			// Check trasition valid.
			if(transition == null)
			{
				throw new BusinessException("The request to change is invalid with the current process.");
			}

			//3 Tìm workflowstep
			var specFlowstep = new EnrollmentWithWorkflowStepSpec(entity.TrainingContentFlowId, transition.ToStepId);

			var flowStep = await _flowStepRepo.GetAsync(specFlowstep, ct);

			if(transition == null)
				throw new Exception($"No transition for action {actionCode}");

			// 4. update step
			entity.TrainingContentStepId = transition.ToStepId;
			entity.TrainingContentFlowStepId = flowStep.Id;
			entity.M_Status = transition.M_Status;

			// 5. log progress (QUAN TRỌNG)
			entity.T_UserTrainingProgress.Add(new T_USER_TRAINING_PROGRESS
			{
				TrainingContentStepId = transition.ToStepId,
				StatusId = transition.StatusId
			});
		}

		// =========================================================
		// 🔥 3. GET AVAILABLE ACTIONS (FE dùng)
		// =========================================================
		public async Task<List<WorkflowActionDTO>> GetAvailableActionsAsync(
			T_USER_TRAINING_ENROLLMENT entity,
			CancellationToken ct)
		{
			var flowStep = await _flowStepRepo.GetByIdAsync(entity.TrainingContentFlowStepId, ct);

			var stepId = flowStep.TrainingContentStepId;

			var transitions = await _transitionRepo.ToListAsync(
				new TransitionSpec(
					stepId,
					null,
					entity.TrainingContentFlowId),
				ct);
			var result = _mapper.Map<List<WorkflowActionDTO>>(transitions);

			return result;
		}
	}
}
