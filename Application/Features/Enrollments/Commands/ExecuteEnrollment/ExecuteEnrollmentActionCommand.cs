using Application.DTOs.Responses.Enrollments;
using Application.Interfaces.Command;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Application.Features.Enrollments.Commands.ExecuteEnrollment
{
	public class ExecuteEnrollmentActionCommand : ICommand<ExecuteEnrollmentActionResponse>
	{
		public int EnrollmentId { get; set; }
		public string ActionCode { get; set; } = string.Empty;
	}
}
