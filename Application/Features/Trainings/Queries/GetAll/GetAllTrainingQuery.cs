using Application.Common.Paging;
using Application.DTOs.Responses.Trainings;
using Application.Interfaces.Queries;

namespace Application.Features.Trainings.Queries.GetAll
{
    public class GetAllTrainingQuery : PagingRequest, IQuery<PagedResult<TrainingListResponse>>
    {
    }
}
