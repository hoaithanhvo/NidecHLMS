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
        public int TrainingContentStepId { get; set; }
        public int StatusId { get; set; }
        public M_STATUS M_Status { get; set; }
        public M_TRAINING_CONTENT_STEP M_TrainingContentStep { get; set; }
        public T_USER_TRAINING_ENROLLMENT T_UserTrainingEnrollment { get; set; }
	}
}
