using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Trainings.Commands.Create
{
	public class CreateTrainingValidator : AbstractValidator<CreateTrainingCommand>
	{
		public CreateTrainingValidator()
		{
			RuleFor(x => x.ManagementNumber)
				.NotEmpty().MaximumLength(20);

			RuleFor(x => x.TrainingContentName)
				.NotEmpty().MaximumLength(300);

			RuleFor(x => x.OperationId)
				.GreaterThan(0);

			RuleFor(x => x.LifecycleId)
				.GreaterThan(0);

		RuleFor(x => x.CreatedBy).NotEmpty().NotNull().WithMessage("CreatedBy is requied");

			RuleFor(x => x.UpdatedBy).NotEmpty().NotEmpty().WithMessage("UpdatedBy is requied");
		}
	}
}