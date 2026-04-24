using Domain.Entities;
using Domain.Specifications;

namespace Application.Features.Trainings.Queries.GetById
{
    public sealed class GetTrainningByIdSpec : BaseSpecification<M_TRAINING_CONTENT>
    {
        public GetTrainningByIdSpec(int id) : base ( checkStatus: false)
        {
            AddInclude(x => x.M_Operation);
            AddInclude(x => x.M_TrainingContentLifecycle);
        }
    }
}
