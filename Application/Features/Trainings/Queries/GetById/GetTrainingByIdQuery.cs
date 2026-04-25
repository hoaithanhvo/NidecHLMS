using Application.DTOs.Responses.Trainings;
using MediatR;

namespace Application.Features.Trainings.Queries.GetById
{
	public class GetTrainingByIdQuery : IRequest<TrainingListResponse>
    {
		public int Id { get; set; }
	}
}
