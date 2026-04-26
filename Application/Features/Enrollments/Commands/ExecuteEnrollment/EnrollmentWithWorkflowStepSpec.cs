using Domain.Entities;
using Domain.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Enrollments.Commands.ExecuteEnrollment
{
	public class EnrollmentWithWorkflowStepSpec : BaseSpecification<M_TRAINING_CONTENT_FLOW_STEP>
	{
		public EnrollmentWithWorkflowStepSpec(int contentFlowId, int contentStepId)
		{
			AddInclude(x => x.TrainingContentStep);
			//AddInclude(x => x.M_Status);

			Criteria = x => x.TrainingContentFlowId == contentFlowId && x.TrainingContentStepId == contentStepId;
		}
	}
}
