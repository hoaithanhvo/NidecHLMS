using Domain.Entities;
using Domain.Specifications;
using System;
using System.Linq.Expressions;

namespace Application.Features.Trainings.Queries.GetList
{
    public sealed class TrainingContentListSpecification : BaseSpecification<M_TRAINING_CONTENT>
    {
        public TrainingContentListSpecification(GetTrainingListQuery query)
           : base(BuildCriteria(query), checkStatus: false)
        {
            ApplyOrderBy(x => x.Id);
            ApplyPaging(query.PageIndex, query.PageSize);
        }
        private static Expression<Func<M_TRAINING_CONTENT, bool>> BuildCriteria(GetTrainingListQuery? query)
        {
            var managementNumber = query?.ManagementNumber?.Trim();
            var trainingContentName = query?.TrainingContentName?.Trim();

            return x =>
                (string.IsNullOrWhiteSpace(managementNumber) ||
                    (!string.IsNullOrEmpty(x.ManagementNumber) && x.ManagementNumber.Contains(managementNumber)))
                && (string.IsNullOrWhiteSpace(trainingContentName) ||
                    (!string.IsNullOrEmpty(x.TrainingContentName) && x.TrainingContentName.Contains(trainingContentName)));
        }
    }
}
