using Domain.Entities;
using Domain.Specifications;

namespace Application.Features.Trainings.Queries.Specs
{
    public sealed class TrainingStatusSpec : BaseSpecification<M_STATUS>
    {
        public TrainingStatusSpec(
            string? type = null,
            string? statusName = null,
            bool? edit = null,
            bool? execute = null,
            bool? view = null)
            : base(checkStatus: false)
        {
            if (!string.IsNullOrWhiteSpace(type))
            {
                var normalizedType = type.Trim().ToUpper();
                AddCriteria(x => x.Type != null && x.Type.Trim().ToUpper() == normalizedType);
            }

            if (!string.IsNullOrWhiteSpace(statusName))
            {
                var normalizedName = statusName.Trim().ToUpper();
                AddCriteria(x => x.StatusName != null && x.StatusName.Trim().ToUpper() == normalizedName);
            }

            if (edit.HasValue)
            {
                AddCriteria(x => x.Edit == edit.Value);
            }

            if (execute.HasValue)
            {
                AddCriteria(x => x.Execute == execute.Value);
            }

            if (view.HasValue)
            {
                AddCriteria(x => x.View == view.Value);
            }

            ApplyOrderBy(x => x.Id);
        }
    }
}
