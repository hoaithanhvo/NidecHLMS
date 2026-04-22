using Domain.Entities;
using Domain.Specifications;

namespace Application.Features.Trainings.Queries.GetById
{
    public sealed class GetTrainningByIdSpec : BaseSpecification<M_TRAINING_CONTENT>
    {
        public GetTrainningByIdSpec(int id) : base (x => x.Id == id && (x.IsDeleted == null || x.IsDeleted == false), checkStatus: false)
        {
            AddInclude(x => x.M_Operation);
            AddInclude(x => x.M_TrainingContentLifecycle);
        }
    }
}
