//using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class T_TRAINING_SESSION : BaseEntity<int>
	{
		public int SessionTypeId { get; set; } // Normal / Retraining
		public int TrainingAttendeeId { get; set; }	
		public DateTime TrainingDate { get; set; }
		public int TrainerId { get; set; }
		public int StatusId { get; set; }
		public string Note { get; set; }
		public M_SESSION_TYPE? M_SESSION_TYPE { get; set; }
		public T_TRAINING_ATTENDEE TrainingAttendees { get; set; }
		public ICollection<T_TRAINING_RESULT> T_TrainingResults { get; set; }

	}
}
