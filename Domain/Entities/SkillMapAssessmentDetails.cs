using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class SkillMapAssessmentDetails
	{
		public int Id { get;set; }
		public int SkillMapAssessmentId { get; set; }
		public decimal Score { get; set; }
		public decimal WeightedScope { get; set; }
		public string Note { get; set; }
		public DateTime CreateDate { get; set; }
		public DateTime UpdateDate { get; set; }
		public int CreateBy { get; set; }
		public int UpdateBy { get;set; }
		public SkillMapAssessments SkillMapAssessment { get; set; }
	}
}
