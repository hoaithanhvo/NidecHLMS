namespace NidecHLMS.API.DTOs.Trainings.Request
{
    public class UpdateTrainingFormRequest
    {
        public string ManagementNumber { get; set; } = string.Empty;
        public string TrainingContentName { get; set; } = string.Empty;
        public int OperationId { get; set; }
        public int LifecycleId { get; set; }
    }
}
