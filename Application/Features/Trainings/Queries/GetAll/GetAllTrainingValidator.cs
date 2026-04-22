using FluentValidation;

namespace Application.Features.Trainings.Queries.GetAll
{
    public class GetAllTrainingValidator : AbstractValidator<GetAllTrainingQuery>
    {
        public GetAllTrainingValidator()
        {
            RuleFor(x => x.PageIndex)
                .GreaterThan(0);

            RuleFor(x => x.PageSize)
                .InclusiveBetween(1, 1000);
        }
    }
}
