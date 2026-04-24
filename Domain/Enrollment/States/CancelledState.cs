using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enrollment.States
{
	public class CancelledState : IEnrollmentState
	{
		public Task ApproveAsync(EnrollmentContext context)
			=> throw new Exception("Đã cancel");

		public Task RejectAsync(EnrollmentContext context)
			=> throw new Exception("Đã cancel");

		public Task EnrollAsync(EnrollmentContext context)
			=> throw new Exception("Đã cancel");

		public Task InprocessAsync(EnrollmentContext context)
			=> throw new Exception("Đã cancel");

		public Task CompleteAsync(EnrollmentContext context)
			=> throw new Exception("Đã cancel");

		public Task CancelAsync(EnrollmentContext context)
			=> throw new Exception("Đã cancel");
	}
}
