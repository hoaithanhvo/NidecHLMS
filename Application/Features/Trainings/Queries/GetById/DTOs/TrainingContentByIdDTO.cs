using Application.Common.DTOs;

namespace Application.Features.Trainings.Queries.GetById.DTOs
{
	public class TrainingContentByIdDTO 
    {
		public int Id { get; set; }
		public string ManagementNumber { get; set; }
		public string TrainingContentName { get; set; }
		public string UpdatedBy { get; set; } = string.Empty;
		public string CreatedBy { get; set; } = string.Empty;
		public OperationDTO Operation { get; set; }
		public TrainingContentLifeCycleDTO TrainingContentLifeCycle { get; set; }
	}
}
