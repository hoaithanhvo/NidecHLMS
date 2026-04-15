using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class T_SKILLMAP : BaseEntity<int>
	{
		public int UserId { get; set; }
		public int AssessmentId { get; set; }	
		public int LevelId { get; set; }
		public string? FilePath { get; set; }
		public int IssueBy { get; set; }
		public int ApproveBy { get; set; }
		public int ConfirmBy { get; set; }
		public string? Note { get; set; }
		public M_LEVEL M_Level { get;set; }
		public ASSESSMENT? Assessments { get; set; }

		public M_USER M_Users{ get; set; }
	}
}
