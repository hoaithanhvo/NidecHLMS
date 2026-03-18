using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class SkillMapAssessments
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public DateTime AssessmentDate { get; set; }
		public Decimal TotalScore { get; set; }
		public string Rank { get; set; }
		public string Result { get; set; }
		public string EvalutedByUserId { get; set; }
		public string ApprovelByUserId { get; set; }
		public string FileLink { get; set; }
		public string Note { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime UpdateDate { get; set; }
		public int CreateBy { get; set; }
		public int UpdateBy { get; set; }
		public int TrainingResultId { get; set; }
		public int SkillMapCriterialId { get; set; }
		public TrainingRequests TrainingRequests { get; set; }
		public ICollection<SkillMapAssessmentDetails> SkillMapAssessmentDetails { get; set; }
		public SkillMapCriteria SkillMapCriteria { get; set; }

	}
}
