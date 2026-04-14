using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class ASSESSMENT : BaseEntity<int>
	{
		public string? AssessmentCode { get; set; }
		public int TrainingDocumentId { get; set; }
		public int Scope { get;set; }
		public string ManagementNumber { get; set; }
		public string FilePath { get; set; }
		public M_TRAINING_DOCUMENT? M_TRAINING_DOCUMENT { get; set; }
		public string ConfirmBy { get;set; }
		public DateTime ConfirmDateTime { get; set; }
		public string ApprovalBy { get; set; }
		public DateTime ApprovalDateTime { get; set; }
		public ICollection<TRAINING_ATTENDEE_DETAIL> TrainingAttendeeDetails { get; set; }
	}
}
