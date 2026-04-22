using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enrollment.States
{
	public class ResignState : IEnrollmentState
	{
		public Task ApproveAsync(EnrollmentContext context)
		{
			context.SetState(new ApprovedState(), (int)EnrollmentStatus.Approved);
			return Task.CompletedTask;
		}

		public Task RejectAsync(EnrollmentContext context)
		{
			context.SetState(new RejectedState(), (int)EnrollmentStatus.Rejected);
			return Task.CompletedTask;
		}

		public Task EnrollAsync(EnrollmentContext context) => throw new Exception("Invalid");
		public Task StartAsync(EnrollmentContext context) => throw new Exception("Invalid");
		public Task CompleteAsync(EnrollmentContext context) => throw new Exception("Invalid");
		public Task CancelAsync(EnrollmentContext context)
		{
			context.SetState(new CancelledState(), (int)EnrollmentStatus.Cancelled);
			return Task.CompletedTask;
		}
	}
}
