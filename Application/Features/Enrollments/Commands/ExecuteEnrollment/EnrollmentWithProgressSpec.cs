using Domain.Entities;
using Domain.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Enrollments.Commands.ExecuteEnrollment
{
	public class EnrollmentWithProgressSpec
	: BaseSpecification<T_USER_TRAINING_ENROLLMENT>
	{
		public EnrollmentWithProgressSpec(int id)
			: base(x => x.Id == id)
		{
			AddInclude(x => x.T_UserTrainingProgress);
		}
	}
}
