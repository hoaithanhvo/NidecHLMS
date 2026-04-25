using Application.Common.DTOs;
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

		public int ActionCode { get; set; }

		public StatusDTO StatusId { get; set; }

		public string? StepName { get; set; }
		public string? ActionName { get; set; }
	}
}
