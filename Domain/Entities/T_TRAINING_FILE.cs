using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class T_TRAINING_FILE : BaseEntity<int>
    {
        public int EnrollmentId { get; set; }              
        public int TrainingContentFlowId { get; set; } 
        public int TrainingContentFlowStepId { get; set; } 

        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string FileType { get; set; }               // pdf, image...

        public string? Note { get; set; }

        public int? UploadedBy { get; set; }
        public DateTime UploadedDate { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime? DeleteDate { get; set; }

        // navigation
        public T_USER_TRAINING_ENROLLMENT T_UserTrainingEnrollment { get; set; }
        public M_TRAINING_CONTENT_FLOW M_TrainingContentFlow { get; set; }
        public M_TRAINING_CONTENT_FLOW_STEP M_TrainingContentFlowStep { get; set; }
    }
}
