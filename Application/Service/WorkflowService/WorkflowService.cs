using Application.Features.Trainings.Queries.GetTransittion;
using Application.Interfaces.Repositories;
using Application.Interfaces.Services;
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

		public WorkflowService(
			IGenericRepository<M_TRAINING_CONTENT_STEP_TRANSITION, int> transitionRepo,
			IGenericRepository<M_TRAINING_CONTENT_FLOW_STEP, int> flowStepRepo)
		{
			_transitionRepo = transitionRepo;
			_flowStepRepo = flowStepRepo;
		}

		// =========================================================
		// 🔥 1. INITIALIZE (Submit)
		// =========================================================
		public async Task InitializeAsync(
			T_USER_TRAINING_ENROLLMENT entity,
			CancellationToken ct)
		{
			// lấy step đầu tiên theo OrderNo
			var firstStep = (await _flowStepRepo.ToListAsync(
				new FirstFlowStepSpec(entity.TrainingContentFlowId), ct))
				.OrderBy(x => x.OrderNo)
				.FirstOrDefault();

			if(firstStep == null)
				throw new Exception("Flow has no steps");

			// set current step
			entity.TrainingContentStepId = firstStep.Id;

			// create first progress
			entity.T_UserTrainingProgress = new List<T_USER_TRAINING_PROGRESS>
			{
				new T_USER_TRAINING_PROGRESS
				{
					TrainingContentStepId = firstStep.Id,
					StatusId = entity.StatusId,
					ActionDate = DateTime.UtcNow,
					CreatedBy = entity.CreatedBy,
					CreatedDate = DateTime.UtcNow,
					UpdatedBy = entity.CreatedBy,
					UpdatedDate = DateTime.UtcNow
				}
			};
		}

		// =========================================================
		// 🔥 2. EXECUTE (Approve / Next / Complete...)
		// =========================================================
		public async Task ExecuteAsync(
			T_USER_TRAINING_ENROLLMENT entity,
			string actionCode,
			CancellationToken ct)
		{
			// 1. get current step từ progress
			var currentFlowStepId = entity.T_UserTrainingProgress
				.OrderByDescending(x => x.ActionDate)
				.FirstOrDefault()?.TrainingContentStepId;

			if(currentFlowStepId == null)
				throw new Exception("No current step");

			var currentFlowStep = await _flowStepRepo.GetByIdAsync(currentFlowStepId.Value, ct);

			var currentStepId = currentFlowStep.TrainingContentStepId;

			// 2. tìm transition
			var spec = new GetTransitionSpec(
				currentStepId,
				actionCode,
				entity.TrainingContentFlowId);

			var transition = await _transitionRepo.GetAsync(spec, ct);

			if(transition == null)
				throw new Exception($"No transition for action {actionCode}");

			// 3. check condition (optional)
			// TODO: plug ConditionEngine

			// 4. update step
			entity.TrainingContentStepId = transition.ToStepId;

			// 5. log progress (QUAN TRỌNG)
			entity.T_UserTrainingProgress.Add(new T_USER_TRAINING_PROGRESS
			{
				TrainingContentStepId = transition.ToStepId,
				StatusId = entity.StatusId,
				ActionDate = DateTime.UtcNow,
				CreatedBy = entity.UpdatedBy,
				CreatedDate = DateTime.UtcNow,
				UpdatedBy = entity.UpdatedBy,
				UpdatedDate = DateTime.UtcNow
			});

			// 6. side effect (optional)
			// TODO: ActionEngine
		}

		// =========================================================
		// 🔥 3. GET AVAILABLE ACTIONS (FE dùng)
		// =========================================================
		public async Task<List<string>> GetAvailableActionsAsync(
			T_USER_TRAINING_ENROLLMENT entity,
			CancellationToken ct)
		{
			var currentStepId = entity.T_UserTrainingProgress
				.OrderByDescending(x => x.ActionDate)
				.FirstOrDefault()?.TrainingContentStepId;

			if(currentStepId == null)
				return new List<string>();

			var transitions = await _transitionRepo.ToListAsync(
				new GetTransitionSpec(
					currentStepId.Value,
					null, // lấy tất cả action
					entity.TrainingContentFlowId),
				ct);

			return transitions
				.Select(x => x.ActionCode)
				.Distinct()
				.ToList();
		}
	}
}
