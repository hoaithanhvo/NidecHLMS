using Application.Features.Trainings.Queries.GetById;
using Domain.Entities;
using Domain.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Trainings.Queries.GetTransittion
{
	public class TransitionSpec : BaseSpecification<M_TRAINING_CONTENT_STEP_TRANSITION>
	{
		public TransitionSpec(int stepId, int? action, int? flowId, bool onlyFlow = false, bool onlyGlobal = false) : base(null)
		{
			AddInclude(x => x.M_Status);
			AddInclude(x => x.M_WorkflowAction);
			if(onlyFlow)
			{
				Criteria = x =>
					x.FromStepId == stepId &&
					x.ActionCode == action &&
					x.TrainingContentFlowId == flowId;
			}
			else if(onlyGlobal)
			{
				Criteria = x =>
					x.FromStepId == stepId &&
					x.ActionCode == action &&
					x.TrainingContentFlowId == null;
			}
			else if(action is null)
			{
				Criteria = x =>
					x.FromStepId == stepId && x.TrainingContentFlowId == null &&
					(x.TrainingContentFlowId == flowId || x.TrainingContentFlowId == null);
			}
			else
			{
				Criteria = x =>
					x.FromStepId == stepId &&
					x.ActionCode == action &&
					(x.TrainingContentFlowId == flowId || x.TrainingContentFlowId == null);
			}

			// ===== PRIORITY ORDER =====
			ApplyOrderByDescending(x => x.TrainingContentFlowId);
		}
	}
}
