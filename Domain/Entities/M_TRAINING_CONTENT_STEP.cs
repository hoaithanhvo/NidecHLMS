using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class M_TRAINING_CONTENT_STEP : BaseEntity<int>
	{
		public string StepCode { get; set; }
		public string StepName { get; set; }
		public int OrderNo { get; set; }	
		public string StepType { get; set; }	
        public ICollection<M_TRAINING_CONTENT_FLOW_STEP> FlowSteps { get; set; }
	}
}
