using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class M_SKILLMAP_TEMPLATE_DETAIL : BaseEntity<int>
    {
        public int TemplateId { get; set; }
        public int CriteriaId { get; set; }

        public int OrderNo { get; set; }         // 1 → 10
        public decimal Weight { get; set; }      // hệ số

        public M_SKILLMAP_TEMPLATE M_SkillmapTemplate { get; set; }
        public M_SKILLMAP_CRITERIA M_SkillmapCriteria { get; set; }
    }
}
