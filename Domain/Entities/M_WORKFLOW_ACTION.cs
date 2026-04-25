using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class M_WORKFLOW_ACTION : BaseEntity<int>
	{
		public string ActionCode { get; set; }
		public string ActionName { get; set; }
		public string Direction { get; set; }
		public int DisplayOrder { get;set; }
		public ICollection<M_TRAINING_CONTENT_STEP_TRANSITION> M_TrainingContentStepTransitions { get; set; }

	}
}
