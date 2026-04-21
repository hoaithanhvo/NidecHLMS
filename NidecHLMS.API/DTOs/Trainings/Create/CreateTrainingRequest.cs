namespace NidecHLMS.API.DTOs.Trainings.Create
{
	public class CreateTrainingRequest
	{
		public string ManagementNumber { get; set; }
		public string TrainingContentName { get; set; }
		public int OperationId { get; set; }
		public int LifecycleId { get; set; }
	}
}
