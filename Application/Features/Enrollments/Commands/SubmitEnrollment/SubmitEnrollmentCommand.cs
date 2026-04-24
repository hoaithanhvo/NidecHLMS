using Application.DTOs.Responses.Enrollments;
using Application.Interfaces.Command;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Application.Features.Enrollments.Commands.RegisterEnrollment
{
	public class SubmitEnrollmentCommand : ICommand<RegisterEnrollmentResponse>
	{
		public int ParticipantId { get; set; }
		public int TrainingContentId { get; set; }
		public int TrainingContentFlowId { get; set; }
		public string EnrollmentCode { get; set; }
	}
}
