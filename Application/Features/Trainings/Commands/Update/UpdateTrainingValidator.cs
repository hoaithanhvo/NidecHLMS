using FluentValidation;

namespace Application.Features.Trainings.Commands.Update
{
    public class UpdateTrainingValidator : AbstractValidator<UpdateTrainingCommand>
    {
        public UpdateTrainingValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0);

            RuleFor(x => x.ManagementNumber)
                .NotEmpty()
                .MaximumLength(20);

            RuleFor(x => x.TrainingContentName)
                .NotEmpty()
                .MaximumLength(300);

            RuleFor(x => x.OperationId)
                .GreaterThan(0);

            RuleFor(x => x.LifecycleId)
                .GreaterThan(0);
        }
    }
}
