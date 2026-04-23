using Domain.Enrollment.Factories;
using Domain.Enrollment.States;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Factories
{
	public class EnrollmentStateFactory : IEnrollmentStateFactory
	{
		public IEnrollmentState Create(int statusId)
		{
			return statusId switch
			{
				(int)EnrollmentStatus.Submitted => new SubmittedState(),
				(int)EnrollmentStatus.Approved => new ApprovedState(),
				(int)EnrollmentStatus.Rejected => new RejectedState(),
				(int)EnrollmentStatus.Enrolled => new EnrolledState(),
				(int)EnrollmentStatus.InProgress => new InProgressState(),
				(int)EnrollmentStatus.Completed => new CompletedState(),
				(int)EnrollmentStatus.Cancelled => new CancelledState(),
				(int)EnrollmentStatus.Resigned => new Resignedtate(),
				_ => throw new Exception("Invalid state")
			};
		}
	}
}
