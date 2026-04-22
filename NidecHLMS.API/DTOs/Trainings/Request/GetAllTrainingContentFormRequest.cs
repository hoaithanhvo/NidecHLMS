using Application.Common.Paging;

namespace NidecHLMS.API.DTOs.Trainings.Request
{
    public class GetAllTrainingContentFormRequest
    {
        public PagingRequest Paging { get; set; } = new PagingRequest();
    }
}
