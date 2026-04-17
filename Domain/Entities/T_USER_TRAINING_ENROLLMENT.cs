using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    internal class T_USER_TRAINING_ENROLLMENT : BaseEntity<int>
    {

        public int ParticipantId { get; set; }
        public int TrainingContentId { get; set; }
        public int CurrentStepId { get; set; }
        public int CurrentFlowStepId { get; set; }
        public int StatusId { get; set; }
        public DateTime? CompleteDate { get; set; }
        public decimal ProgressPercent { get; set; }
        public T_USER_TRAINING_PROGRESS T_UserTrainingProgress { get; set; }
        public M_USER M_User { get; set; }
        public M_TRAINING_CONTENT M_TrainingContent { get; set; }
        public M_TRAINING_CONTENT_STEP M_TrainingContentStep { get; set; }
        public M_TRAINING_CONTENT_FLOW_STEP M_TrainingContentFlowStep { get; set; }
    }
}
