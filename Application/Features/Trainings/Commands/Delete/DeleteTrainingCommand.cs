using Application.Interfaces.Command;

namespace Application.Features.Trainings.Commands.Delete
{
    public class DeleteTrainingCommand : ICommand<bool>
    {
        public int Id { get; set; }
    }
}
