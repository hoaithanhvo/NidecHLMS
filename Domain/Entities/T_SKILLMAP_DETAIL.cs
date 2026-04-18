using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class T_SKILLMAP_DETAIL : BaseEntity<int>
    {
        public int SkillmapResultId { get; set; }
        public int CriteriaId { get; set; }

        public decimal Score { get; set; }       // điểm user nhập
        public decimal TotalScore { get; set; }  // Score * Weight

        public string? Note { get; set; }

        public T_SKILLMAP_RESULT T_SkillmapResult { get; set; }
        public M_SKILLMAP_CRITERIA M_SkillmapCriteria { get; set; }
    }
}
