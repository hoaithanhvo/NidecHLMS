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
		public int LearningReportId { get; set; }	
		public string Note { get; set; }

		public int StatusId { get; set; }
		public M_STATUS M_STATUS { get; set; }

		public int AssessmentId { get; set; }
		public ASSESSMENT Assessment { get; set; }

		public int TrainingSessionId { get; set; }
		public TRAINING_ATTENDEE_SESSION TrainingSession { get; set; }
	}
}
