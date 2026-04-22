using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enrollment.States
{
	public class RejectedState : IEnrollmentState
	{
		public Task ApproveAsync(EnrollmentContext context)
			=> throw new Exception("Đã reject không thể duyệt");

		public Task RejectAsync(EnrollmentContext context)
			=> throw new Exception("Đã reject");

		public Task EnrollAsync(EnrollmentContext context)
			=> throw new Exception("Không thể enroll");

		public Task StartAsync(EnrollmentContext context)
			=> throw new Exception("Không thể start");

		public Task CompleteAsync(EnrollmentContext context)
			=> throw new Exception("Không thể complete");

		public Task CancelAsync(EnrollmentContext context)
			=> throw new Exception("Không thể cancel");
	}
}
