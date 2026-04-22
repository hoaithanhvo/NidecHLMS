using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enrollment.States
{
	public interface IEnrollmentState
	{
		Task ApproveAsync(EnrollmentContext context);
		Task RejectAsync(EnrollmentContext context);
		Task EnrollAsync(EnrollmentContext context);
		Task StartAsync(EnrollmentContext context);
		Task CompleteAsync(EnrollmentContext context);
		Task CancelAsync(EnrollmentContext context);
	}
}
