using FluentValidation;

namespace Application.Features.Trainings.Queries.GetList
{
    public class GetTrainingListValidator : AbstractValidator<GetTrainingListQuery>
    {
        public GetTrainingListValidator()
        {
            RuleFor(x => x.PageIndex)
                .GreaterThan(0);

            RuleFor(x => x.PageSize)
                .InclusiveBetween(1, 1000);
        }
    }
}
