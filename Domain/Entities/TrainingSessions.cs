using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class TrainingSessions
	{
		public int Id { get; set; }
		
		public int TrainingRequestId { get; set; }

		public int TrainingCategoryId { get; set; }	

		public string TrainingPhase { get; set; }

		public int TrainerUserId { get; set; }

		public string Location { get; set; }

		public DateTime StartDate { get; set; }

		public DateTime EndDate { get; set; }	

		public string Status { get; set; }

		public string Note { get; set; }

		public DateTime CreateDate { get; set; }

		public DateTime UpdateDate { get; set; }

		public int CreateBy { get; set; }

		public int UpdateBy { get;set; }

		public ICollection<TrainingResults> TrainingResults { get; set; }	

		public TrainingRequests TrainingRequest { get; set; }	
	}
}
