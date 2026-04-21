using Domain.Entities;

namespace NidecHLMS.API.DTOs.Trainings.Responses
{
	public class OperationDetailResponse
	{
		public string OperationCode { get; set; }
		public string OperationName { get; set; }
		public int DepartmentId { get; set; }
		public int ObjectId { get; set; }
		public string ManagementNumber { get; set; }
		public int? SkillmapTemplateId { get; set; }
	}
}
