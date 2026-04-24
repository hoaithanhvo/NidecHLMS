using Application.DTOs.Responses.Enrollments;
using Application.Features.Trainings.Queries.GetAll;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Enrollments.Commands.SubmitEnrollment
{
	public class SubmitEnrollmentValidator : AbstractValidator<RegisterEnrollmentResponse>
	{
		public SubmitEnrollmentValidator() {
		}
	}
}
