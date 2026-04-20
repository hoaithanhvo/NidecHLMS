using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class T_USER_TAG : BaseEntity<int>
    {
        public int ParticipantId { get; set; }
        public int UserTrainingEnrollmentId { get; set; }
        public int TagId { get; set; }
        public M_TAG M_Tag { get; set; }
        public T_TRAINING_PARTICIPANT T_TrainingParticipant { get; set; }
        public T_USER_TRAINING_ENROLLMENT T_UserTrainingEnrollment { get; set; }
    }
}
