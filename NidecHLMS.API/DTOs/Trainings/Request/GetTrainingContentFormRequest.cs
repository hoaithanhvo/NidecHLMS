using Application.Common.Paging;

namespace NidecHLMS.API.DTOs.Trainings.Request
{
	public class GetTrainingContentFormRequest
	{
		public PagingRequest Paging { get; set; } = new PagingRequest();
		public string? Keyword { get; set; }
	}
}
