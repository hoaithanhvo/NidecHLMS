using Application.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Responses.Trainings
{
	public class TrainingListResponse
	{
		public int Id { get; set; }
		public string ManagementNumber { get; set; }
		public string TrainingContentName { get; set; }
		public OperationDTO Operation { get; set; }
		public TrainingContentLifeCycleDTO Lifecycle { get; set; }
		public string UpdatedBy { get; set; } = string.Empty;
		public string CreatedBy { get; set; } = string.Empty;
	}
}
