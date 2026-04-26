using Application.DTOs.Responses.Enrollments;
using Application.Features.Enrollments.Commands.RegisterEnrollment;
using Application.Features.Trainings.Queries.GetAll;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Enrollments.Commands.SubmitEnrollment
{
	public class SubmitEnrollmentValidator : AbstractValidator<SubmitEnrollmentCommand>
	{
		public SubmitEnrollmentValidator() {
			RuleFor(x => x.EnrollmentCode).NotEmpty().WithMessage("EnrollmentCode is required");

			RuleFor(x => x.ParticipantId)
				.GreaterThan(0)
				.WithMessage("ParticipantId must be greater than 0");

			RuleFor(x => x.TrainingContentId)
				.GreaterThan(0)
				.WithMessage("TrainingContentId must be greater than 0");

			RuleFor(x => x.TrainingContentFlowId)
				.GreaterThan(0)
				.WithMessage("TrainingContentFlowId must be greater than 0");
		}
	}
}
