using Application.Interfaces.Command;

namespace Application.Features.Trainings.Commands.Update
{
    public class UpdateTrainingCommand : ICommand<bool>
    {
        public int Id { get; set; }
        public string ManagementNumber { get; set; } = string.Empty;
        public string TrainingContentName { get; set; } = string.Empty;
        public int OperationId { get; set; }
        public int LifecycleId { get; set; }
    }
}
