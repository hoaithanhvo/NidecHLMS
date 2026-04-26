using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Specifications
{
	public class FirstFlowStepSpec : BaseSpecification<M_TRAINING_CONTENT_FLOW_STEP>
	{
		public FirstFlowStepSpec(int flowId)
			: base(x => x.TrainingContentFlowId == flowId)
		{
			AddInclude(x => x.TrainingContentFlow);
			AddInclude(x => x.TrainingContentStep);
			ApplyOrderBy(x => x.OrderNo);
		}
	}
}
