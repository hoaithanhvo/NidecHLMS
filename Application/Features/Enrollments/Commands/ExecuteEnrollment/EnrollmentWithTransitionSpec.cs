using Domain.Entities;
using Domain.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Enrollments.Commands.ExecuteEnrollment
{
	public class EnrollmentWithTransitionSpec : BaseSpecification<M_TRAINING_CONTENT_STEP_TRANSITION>
	{
		public EnrollmentWithTransitionSpec(M_TRAINING_CONTENT_STEP trainingContentStep) {

			Criteria = x => x.FromStep == trainingContentStep;

		}
	}
}
