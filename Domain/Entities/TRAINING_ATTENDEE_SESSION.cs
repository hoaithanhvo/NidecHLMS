using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class TRAINING_ATTENDEE_SESSION : BaseEntity<int>
	{
		public int TrainingAttendeeId { get; set; }
		public int SessionTypeId { get; set; } // Normal / Retraining
		public DateTime TrainingDate { get; set; }
		public int TrainerId { get; set; }
		public int StatusId { get; set; }
		public string Note { get; set; }
		public TRAINING_ATTENDEE TRAINING_ATTENDEE { get; set; }
		public ICollection<TRAINING_ATTENDEE_DETAIL> Details { get; set; }
		public M_SESSION_TYPE M_SESSION_TYPE { get; set; }
	}
}
