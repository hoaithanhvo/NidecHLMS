using Domain.Entities;
using Domain.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Trainings.Queries.GetTransittion
{
	public class GetTransitionSpec : BaseSpecification<M_TRAINING_CONTENT_STEP_TRANSITION>
	{
		public GetTransitionSpec(int stepId, string action, int? flowId, bool onlyFlow = false, bool onlyGlobal = false): base(null)
		{
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
