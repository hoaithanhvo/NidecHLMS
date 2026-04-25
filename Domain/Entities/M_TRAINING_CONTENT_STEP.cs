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
		public int StatusId { get; set; }
		public M_STATUS M_Status { get; set; }

		public ICollection<M_TRAINING_CONTENT_FLOW_STEP> FlowSteps { get; set; }
        public ICollection<M_TRAINING_CONTENT_STEP_TRANSITION> FromTransitions { get; set; }
        public ICollection<M_TRAINING_CONTENT_STEP_TRANSITION> ToTransitions { get; set; }
        public ICollection<T_USER_TRAINING_ENROLLMENT> T_UserTrainingEnrollments { get; set; }
        public ICollection<T_USER_TRAINING_PROGRESS> T_UserTrainingProgress { get; set; }
	}
}
