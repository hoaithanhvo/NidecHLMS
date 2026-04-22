using FluentValidation;

namespace Application.Features.Trainings.Queries.GetById
{
    public class GetTrainningValidator : AbstractValidator<GetTrainingByIdQuery>
    {
        public GetTrainningValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0);
        }
    }
}
