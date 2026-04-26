using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class M_STEP_REQUIREMENT : BaseEntity<int>
	{
		// STEP (PRIMARY)
		public int TrainingContentStepId { get; set; }
		public M_TRAINING_CONTENT_STEP M_TrainingContentStep { get; set; }

		// FLOW OVERRIDE (OPTIONAL)
		public int? TrainingContentFlowId { get; set; }
		public M_TRAINING_CONTENT_FLOW? M_TrainingContentFlow { get; set; }

		// REQUIREMENT INFO
		public string RequirementCode { get; set; } = default!;
		public string RequirementName { get; set; } = default!;

		// 🔥 FK TO DB ENUM
		public int RequirementTypeId { get; set; }
		public M_REQUIREMENT_TYPE M_RequirementType { get; set; }

		// RULE CONFIG
		public bool IsRequired { get; set; }
		public int DisplayOrder { get; set; }

		public string? Placeholder { get; set; }
		public string? DefaultValue { get; set; }
		public string? ValidationRegex { get; set; }

		public decimal? MinValue { get; set; }
		public decimal? MaxValue { get; set; }

		// FILE CONFIG
		public string? FileType { get; set; }
		public long? MaxFileSize { get; set; }
		public bool IsMultiple { get; set; }
		public bool IsReadOnly { get; set; }
	}
}
