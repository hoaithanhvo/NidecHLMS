using Application.Features.Trainings.Queries.GetList;
using Domain.Entities;
using Domain.Specifications;
using System;
using System.Linq.Expressions;

namespace Application.Features.Trainings.Queries.Specs
{
    public sealed class TrainingContentByKeywordSpec : BaseSpecification<M_TRAINING_CONTENT>
    {
        public TrainingContentByKeywordSpec(GetTrainingListQuery query, bool isPaging = true)
        : base(BuildCriteria(query), checkStatus: false)
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
        private static Expression<Func<M_TRAINING_CONTENT, bool>> BuildCriteria(GetTrainingListQuery query)
        {
            var keyword = query.Keyword?.Trim();

            return x =>
                (string.IsNullOrEmpty(keyword) ||
                 x.ManagementNumber.Contains(keyword) ||
                 x.TrainingContentName.Contains(keyword))

                && x.M_Status != null
                && x.M_Status.StatusName == "ACTIVE"
                && x.M_Status.Type == "root";
        }
    }
}



