using Application.Features.Trainings.Queries.GetAll;
using Domain.Entities;
using Domain.Specifications;
using System.Linq.Expressions;

namespace Application.Features.Trainings.Queries.Specs
{
    public sealed class GetAllTrainingContentSpec : BaseSpecification<M_TRAINING_CONTENT>
    {
        public GetAllTrainingContentSpec(GetAllTrainingQuery query, bool isPaging = true)
            : base(IsActive(), checkStatus: false)
        {
            AddInclude(x => x.M_Operation);
            AddInclude(x => x.M_TrainingContentLifecycle);
            AddInclude(x => x.M_Status);
            AddInclude(x => x.M_TrainingDocuments);

            ApplyOrderBy(x => x.Id);

            if (isPaging)
            {
                ApplyPaging(query.PageIndex, query.PageSize);
            }

        }
        private static Expression<Func<M_TRAINING_CONTENT, bool>> IsActive()
        {
            return x => x.M_Status != null && x.M_Status.StatusName == "ACTIVE" && x.M_Status.Type == "root";
        }
    }
}
