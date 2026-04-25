using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.DTOs
{
	public class EnrollmentDTO
	{
		public int ParticipantId { get; set; }
		public string EnrollmentCode { get; set; }
		public int TrainingContentId { get; set; }
		public int TrainingContentFlowId { get; set; }
		public int TrainingContentFlowStepId { get; set; }
		public int TrainingContentStepId { get; set; }
		public int StatusId { get; set; }
		public DateTime? CompleteDate { get; set; }
		public decimal ProgressPercent { get; set; }
	}
}
