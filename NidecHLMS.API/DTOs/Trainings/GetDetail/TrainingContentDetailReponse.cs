namespace NidecHLMS.API.DTOs.Trainings.Responses
{
	public class TrainingContentDetailReponse
	{
		public string ManagementNumber { get; set; }	
		public string TrainingContentName { get; set; }
		public OperationDetailResponse Operation { get; set; }
		public int LifeCyleId { get; set; }
	}
}
