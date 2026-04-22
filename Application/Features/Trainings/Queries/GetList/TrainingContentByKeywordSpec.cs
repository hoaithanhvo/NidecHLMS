using Domain.Entities;
using Domain.Specifications;
using System;
using System.Linq.Expressions;

namespace Application.Features.Trainings.Queries.GetList
{
	public sealed class TrainingContentByKeywordSpec : BaseSpecification<M_TRAINING_CONTENT>
	{
		public TrainingContentByKeywordSpec(GetTrainingListQuery query)
		   : base(BuildCriteria(query), checkStatus: false)
		{
			AddInclude(x => x.M_Operation);
			AddInclude(x => x.M_TrainingContentLifecycle);
			AddInclude(x => x.M_TrainingDocuments);
			ApplyOrderBy(x => x.Id);
			ApplyPaging(query.PageIndex, query.PageSize);
			
		}
		private static Expression<Func<M_TRAINING_CONTENT, bool>> BuildCriteria(GetTrainingListQuery? query)
		{
			var keyWord = query?.Keyword?.ToLower().Trim();

			return x =>
			(string.IsNullOrWhiteSpace(keyWord) ||
				(x.ManagementNumber.ToLower().Contains(keyWord)) ||
					(x.TrainingContentName.ToLower().Contains(keyWord))
			);
		}
	}
}
