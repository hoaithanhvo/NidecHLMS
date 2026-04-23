using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enrollment.States
{
	public class ApprovedState : IEnrollmentState
	{
		public Task EnrollAsync(EnrollmentContext context)
		{
			context.SetState(new EnrolledState(), (int)EnrollmentStatus.Enrolled);
			return Task.CompletedTask;
		}

		public Task CancelAsync(EnrollmentContext context)
		{
			context.SetState(new CancelledState(), (int)EnrollmentStatus.Cancelled);
			return Task.CompletedTask;
		}

		public Task ApproveAsync(EnrollmentContext context) => throw new Exception("Invalid");
		public Task RejectAsync(EnrollmentContext context) => throw new Exception("Invalid");
		public Task InprocessAsync(EnrollmentContext context) => throw new Exception("Invalid");
		public Task CompleteAsync(EnrollmentContext context) => throw new Exception("Invalid");
	}
}
