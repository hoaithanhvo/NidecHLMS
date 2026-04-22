using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enrollment.States
{
	public class EnrolledState : IEnrollmentState
	{
		public Task StartAsync(EnrollmentContext context)
		{
			context.SetState(new InProgressState(), (int)EnrollmentStatus.Resign);
			return Task.CompletedTask;
		}

		public Task CancelAsync(EnrollmentContext context)
		{
			context.SetState(new CancelledState(), (int)EnrollmentStatus.Cancelled);
			return Task.CompletedTask;
		}

		public Task ApproveAsync(EnrollmentContext context) => throw new Exception();
		public Task RejectAsync(EnrollmentContext context) => throw new Exception();
		public Task EnrollAsync(EnrollmentContext context) => throw new Exception();
		public Task CompleteAsync(EnrollmentContext context) => throw new Exception("Chưa học");
	}
}
