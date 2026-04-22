using Application.Features.Trainings.Queries.GetAll;
using Domain.Entities;
using Domain.Specifications;

namespace Application.Features.Trainings.Queries.Specs
{
    public sealed class GetAllTrainingContentSpec : BaseSpecification<M_TRAINING_CONTENT>
    {
        public GetAllTrainingContentSpec(GetAllTrainingQuery query, bool isPaging = true)
            : base(x => true, checkStatus: false)
        {
            AddInclude(x => x.M_Operation);
            AddInclude(x => x.M_TrainingContentLifecycle);
            AddInclude(x => x.M_TrainingDocuments);

            ApplyOrderBy(x => x.Id);

            if (isPaging)
            {
                ApplyPaging(query.PageIndex, query.PageSize);
            }
        }
    }
}
