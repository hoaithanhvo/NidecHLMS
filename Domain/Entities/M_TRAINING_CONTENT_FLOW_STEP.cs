using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class M_TRAINING_CONTENT_FLOW_STEP : BaseEntity<int>
	{
		// ===== FK =====
		public int TrainingContentFlowId { get; set; }
		public int TrainingContentStepId { get; set; }

		// ===== Order trong flow =====
		public int OrderNo { get; set; }

		// ===== Rule per step =====
		public bool IsMandatory { get; set; } = true;
		public int? DurationDays { get; set; }  // optional: step timeout

		// ===== Navigation =====
		public M_TRAINING_CONTENT_FLOW TrainingContentFlow { get; set; }
		public M_TRAINING_CONTENT_STEP TrainingContentStep { get; set; }
		public ICollection<T_USER_TRAINING_ENROLLMENT> T_UserTrainingEnrollment { get; set; }
	}
}
