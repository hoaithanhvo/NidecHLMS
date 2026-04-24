using FluentValidation;

namespace Application.Features.Trainings.Commands.Delete
{
    public class DeleteTrainingValidator : AbstractValidator<DeleteTrainingCommand>
    {
        public DeleteTrainingValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0);
        }
    }
}
