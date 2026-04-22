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
				(int)EnrollmentStatus.Resign => new ResignState(),
				(int)EnrollmentStatus.Approved => new ApprovedState(),
				(int)EnrollmentStatus.Rejected => new RejectedState(),
				(int)EnrollmentStatus.Enrolled => new EnrolledState(),
				(int)EnrollmentStatus.InProgress => new InProgressState(),
				(int)EnrollmentStatus.Completed => new CompletedState(),
				(int)EnrollmentStatus.Cancelled => new CancelledState(),
				_ => throw new Exception("Invalid state")
			};
		}
	}
}
