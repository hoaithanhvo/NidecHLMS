using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class T_USER_TRAINING_PROGRESS : BaseEntity<int>
	{
        public int Id { get; set; }
        public int UserTrainingEnrollmentId { get; set; }
        public int TrainingContentFlowStepId { get; set; }
        public int StatusId { get; set; }
        public DateTime ActionDate { get; set; }
        public DateTime? DeleteDate { get; set; }

		public M_STATUS M_Status { get;set;}
        public M_TRAINING_CONTENT_FLOW_STEP M_TrainingContentFlowStep { get; set; }
        public T_USER_TRAINING_ENROLLMENT T_UserTrainingEnrollment { get; set; }    
    }
}
