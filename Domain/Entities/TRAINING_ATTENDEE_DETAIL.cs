using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class TRAINING_ATTENDEE_DETAIL : BaseEntity<int>
	{
		public int TrainingSessionId { get; set; }
		public int LevelId { get; set; }
		public int StatusId { get; set; }
		public string 
		public string Note { get; set; }



		public TRAINING_ATTENDEE_SESSION TRAINING_SESSION { get; set; }
		public M_STATUS M_STATUS { get; set; }
	}
}
