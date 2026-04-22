using Application.Common.Paging;
using Application.DTOs.Responses.Trainings;
using Application.Interfaces.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Trainings.Queries.GetList
{
	public class GetTrainingListQuery : PagingRequest, IQuery<PagedResult<TrainingListResponse>>
	{
		public string ManagementNumber { get; set; } = string.Empty;
		public string TrainingContentName { get; set; } = string.Empty;
		public int OperationId { get; set; }
		public int LifecycleId { get; set; }
		public string UpdatedBy { get; set; } = string.Empty;
		public string CreatedBy { get; set; } = string.Empty;
		public string? Keyword { get; set; }
	}
}
