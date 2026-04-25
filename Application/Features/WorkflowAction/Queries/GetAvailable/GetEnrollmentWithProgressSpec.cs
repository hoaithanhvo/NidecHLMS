using Domain.Entities;
using Domain.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.WorkflowAction.Queries.GetAvailable
{
	public class GetEnrollmentWithProgressSpec
	: BaseSpecification<T_USER_TRAINING_ENROLLMENT>
	{
		public GetEnrollmentWithProgressSpec(int id)
			: base(x => x.Id == id)
		{
			AddInclude(x => x.T_UserTrainingProgress);
		}
	}
}
