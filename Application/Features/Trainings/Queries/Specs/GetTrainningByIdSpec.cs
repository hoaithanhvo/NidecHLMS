using Domain.Entities;
using Domain.Specifications;

namespace Application.Features.Trainings.Queries.Specs
{
    public sealed class GetTrainningByIdSpec : BaseSpecification<M_TRAINING_CONTENT>
    {
        public GetTrainningByIdSpec(int id) : base(x => x.Id == id
             && x.M_Status != null
             && x.M_Status.StatusName == "ACTIVE"
             && x.M_Status.Type == "root", checkStatus: false)
        {
            AddInclude(x => x.M_Operation);
            AddInclude(x => x.M_TrainingContentLifecycle);
            AddInclude(x => x.M_Status);
        }
    }
}
