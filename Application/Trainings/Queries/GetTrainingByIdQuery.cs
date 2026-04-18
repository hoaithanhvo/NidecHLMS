using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Trainings.Queries
{
    public class GetTrainingByIdQuery : IRequest<TrainingDto>
    {
        public int Id { get; set; }
    }
}
