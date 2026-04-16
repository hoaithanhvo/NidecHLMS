using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class M_TRAINING_CONTENT_FLOW : BaseEntity<int>
	{
		public int TrainingContentId { get; set; }

		// ===== Business =====
		public string Code { get; set; }          // FLOW_STANDARD, FLOW_SHORT
		public string Name { get; set; }

		public int Version { get; set; } = 1;

		// ===== Rule =====
		public bool IsDefault { get; set; }       // flow mặc định của course
		public bool IsActive { get; set; } = true;

		// ===== Metadata =====
		public string? Description { get; set; }

		// ===== Navigation =====
		public M_TRAINING_CONTENT TrainingContent { get; set; }
		public ICollection<M_TRAINING_CONTENT_FLOW_STEP> FlowSteps { get; set; }
	}
}
