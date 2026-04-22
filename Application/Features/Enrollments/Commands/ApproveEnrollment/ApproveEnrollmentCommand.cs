using Application.Interfaces.Command;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Enrollments.Commands.ApproveEnrollment
{
	public class ApproveEnrollmentCommand : ICommand<Unit>
	{
		public int Id { get; set; }
	}
}
