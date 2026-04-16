using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class T_ASSESSMENT : BaseEntity<int>
	{
		public string AssessmentCode { get; set; }
		public int TrainingDocumentId { get; set; }
		public int Scope { get;set; }
		public string ManagementNumber { get; set; }
		public string FilePath { get; set; }
		public M_TRAINING_DOCUMENT M_TRAINING_DOCUMENT { get; set; }
		public int ConfirmBy { get;set; }
		public DateTime ConfirmDateTime { get; set; }
		public int ApprovalBy { get; set; }
		public DateTime ApprovalDateTime { get; set; }
		public bool? IsDeleted { get; set; }
		public DateTime? DeleteDate { get; set; }
		public ICollection<T_SKILLMAP> Skillmaps { get; set; }
		public ICollection<T_ASSESSMENT_RESULT> T_AssetssmentResults { get; set; }
		public M_USER M_Users { get; set; }
	}
}
