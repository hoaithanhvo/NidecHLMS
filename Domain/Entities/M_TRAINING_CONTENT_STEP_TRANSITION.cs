using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class M_TRAINING_CONTENT_STEP_TRANSITION : BaseEntity<int>
	{
		// optional (pro level)
		public int? TrainingContentFlowId { get; set; }

		// ===== FK =====
		public int FromStepId { get; set; }
		public int ToStepId { get; set; }

		// ===== Action =====
		public int ActionCode { get; set; }
		// NEXT, PASS, FAIL, SKIP

		// ===== Condition (optional) =====
		public string? ConditionType { get; set; }     // Score, Role...
		public string? ConditionValue { get; set; }    // >=80, Manager...

		// ===== Rule =====
		public bool IsDefault { get; set; } = false;
		public bool IsActive { get; set; } = true;

		// ===== Navigation =====
		public M_TRAINING_CONTENT_STEP FromStep { get; set; }
		public M_TRAINING_CONTENT_STEP ToStep { get; set; }
		public M_TRAINING_CONTENT_FLOW M_TrainingContentFlow { get; set; }
		public M_WORKFLOW_ACTION M_WorkflowAction { get; set; }
	}
}
