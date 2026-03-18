using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class TrainingResults
	{
		public int Id { get; set; } 
		public int TrainingSessionId { get; set; }
		public decimal TheoryScore { get; set; }
		public decimal PracticeScore { get; set; }
		public decimal ProductJudgmentScore { get; set; }
		public string Result { get; set; } = null!;
		public string EvaluatedByUserId { get; set; } = null!;
		public DateTime EvaluatedDate { get; set; } 
		public string Note { get; set; } = null!;	
		public DateTime CreateDate { get; set; }	
		public DateTime UpdateDate { get; set; }
		public int CreateBy { get; set; }
		public int UpdateBy { get; set; }
		public ICollection<Certificates> Certificates { get; set; }
		public TrainingSessions TrainingSessions { get; set; }
	}
}
