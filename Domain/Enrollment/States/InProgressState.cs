using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enrollment.States
{
	public class InProgressState : IEnrollmentState
	{
		public Task CompleteAsync(EnrollmentContext context)
		{
			context.SetState(new CompletedState(), (int)EnrollmentStatus.Completed);
			return Task.CompletedTask;
		}

		public Task CancelAsync(EnrollmentContext context)
			=> throw new Exception("Đang học không được hủy");

		public Task ApproveAsync(EnrollmentContext context) => throw new Exception();
		public Task RejectAsync(EnrollmentContext context) => throw new Exception();
		public Task EnrollAsync(EnrollmentContext context) => throw new Exception();
		public Task StartAsync(EnrollmentContext context) => throw new Exception();
	}
}