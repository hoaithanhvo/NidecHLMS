using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enrollment.States
{
	public class CompletedState : IEnrollmentState
	{
		public Task ApproveAsync(EnrollmentContext context) => throw new Exception();
		public Task RejectAsync(EnrollmentContext context) => throw new Exception();
		public Task EnrollAsync(EnrollmentContext context) => throw new Exception();
		public Task InprocessAsync(EnrollmentContext context) => throw new Exception();
		public Task CompleteAsync(EnrollmentContext context) => throw new Exception();
		public Task CancelAsync(EnrollmentContext context)
			=> throw new Exception("Đã hoàn thành không được hủy");
	}
}
