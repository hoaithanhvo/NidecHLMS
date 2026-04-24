using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Responses.Enrollments
{
	public class ExecuteEnrollmentActionResponse
	{
		public int EnrollmentId { get; set; }
		public int FromStepId { get; set; }
		public int ToStepId { get; set; }
		public string ActionCode { get; set; } = string.Empty;
		public DateTime ExecutedAt { get; set; }
		public bool Success { get; set; }
	}
}
