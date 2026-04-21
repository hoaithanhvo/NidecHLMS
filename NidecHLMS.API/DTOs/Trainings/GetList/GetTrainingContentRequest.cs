using Application.Common.Paging;

namespace NidecHLMS.API.DTOs.Trainings.GetList
{
	public class GetTrainingContentRequest
	{
		public PagingRequest Paging { get; set; } = new PagingRequest();
		public string? Keyword { get; set; }
	}
}
