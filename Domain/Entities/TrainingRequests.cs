using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class TrainingRequests
	{
		public int Id { get; set; }	
		public int TrainingCategoryId { get; set; }
		public string Reason { get; set; }
		public int RequestByUserId { get; set; }
		public DateTime RequestDate { get; set; }
		public string Status { get; set; }
		public int ApprovedByUserId { get; set; }
		public DateTime ApprovedDate { get; set; }
		public string Note { get; set; }
		public DateTime CreateDate { get; set; }
		public DateTime UpdateDate { get; set; }
		public int CreateUserId { get; set; }
		public int UpdateUserId { get; set; }
		public int  SkillTypeid { get; set; }
		public ICollection<TrainingSessions> TrainingSessions { get; set; }
		public ICollection<TrainingRequestUsers> TrainingRequestUser { get; set; }
		public ICollection<SkillMapAssessments> SkillMapAssessment { get; set; }
	}
}
