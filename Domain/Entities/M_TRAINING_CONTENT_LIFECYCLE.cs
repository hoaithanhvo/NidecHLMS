using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class M_TRAINING_CONTENT_LIFECYCLE : BaseEntity<int>
	{
		// ===== Business Key =====
		public string Code { get; set; }
		public string Name { get; set; }

		// ===== Rule Engine =====
		public bool IsRenew { get; set; }
		public int RetrainingFrequency { get; set; }
		public string? FrequencyUnit { get; set; } // DAY / MONTH / YEAR

		// ===== UI / Sort =====
		public int OrderNo { get; set; }

		// ===== Metadata =====
		public string? Description { get; set; }
		public bool IsActive { get; set; } = true;

		// ===== Audit (nếu BaseEntity chưa có thì thêm) =====
		public DateTime CreatedDate { get; set; }
		public string? CreatedBy { get; set; }
		public DateTime? UpdatedDate { get; set; }
		public string? UpdatedBy { get; set; }

		// ===== Navigation =====
		public ICollection<M_TRAINING_CONTENT>? M_TrainingContents { get; set; }
	}
}
