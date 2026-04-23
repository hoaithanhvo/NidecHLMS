namespace NidecHLMS.API.DTOs.Enrollments
{
	public class SubmitUserTrainingEnrollmentFormRequest
	{
		public int ParticipantId { get; set; }
		public int TrainingContentId { get; set; }
		public int TrainingContentFlowId { get; set; }
		public string EnrollmentCode { get; set; } = string.Empty;
	}
}
