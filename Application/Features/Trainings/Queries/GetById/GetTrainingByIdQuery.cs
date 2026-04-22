using Application.Features.Trainings.Queries.GetById.DTOs;
using MediatR;

namespace Application.Features.Trainings.Queries.GetById
{
	public class GetTrainingByIdQuery : IRequest<TrainingContentByIdDTO>
    {
		public int Id { get; set; }
	}
}
