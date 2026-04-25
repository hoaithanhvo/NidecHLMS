using Domain.Entities;
using Domain.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Enrollments.Commands.SubmitEnrollment
{
	public sealed class SubmitEnrollmentSpec : BaseSpecification<T_USER_TRAINING_ENROLLMENT>
	{
		public SubmitEnrollmentSpec(string enrollmentCode) : base(x => x.EnrollmentCode == enrollmentCode)
		{
			
		}
	}
}
