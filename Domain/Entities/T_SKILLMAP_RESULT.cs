using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class T_SKILLMAP_RESULT : BaseEntity<int>
    {
        public int EnrollmentId { get; set; }

        public decimal TotalScore { get; set; }
        public int Rank { get; set; }
        public bool IsPass { get; set; }

        public string? Evaluator { get; set; }
        public DateTime EvaluationDate { get; set; }

        public string? FilePath { get; set; }

        public ICollection<T_SKILLMAP_DETAIL> T_SkillmapDetails { get; set; }

        public T_USER_TRAINING_ENROLLMENT T_UserTrainingEnrollment { get; set; }

        public M_LEVEL M_Level { get; set; }    
    }
}
