using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class T_USER_TRAINING_ENROLLMENT : BaseEntity<int>
    {
        public int ParticipantId { get; set; }
        public string EnrollmentCode { get; set; } // auto generate
        public int TrainingContentId { get; set; }
        public int TrainingContentFlowId { get; set; }
        public int StatusId { get; set; }
        public DateTime? CompleteDate { get; set; }
        public decimal ProgressPercent { get; set; }
        public M_STATUS M_Status { get; set; }
        public T_TRAINING_PARTICIPANT T_TrainingParticipant { get; set; }
        public M_TRAINING_CONTENT M_TrainingContent { get; set; }
        public M_TRAINING_CONTENT_FLOW M_TrainingContentFlow { get; set; }
        public ICollection<T_USER_TRAINING_PROGRESS> T_UserTrainingProgress { get; set; } 
        public ICollection<T_TRAINING_FILE> T_TrainingFiles { get; set; } 
        public ICollection<T_SKILLMAP_RESULT> T_SkillmapResults { get; set; } 
        public ICollection<T_USER_TAG> T_UserTags { get; set; } 
    }
}
