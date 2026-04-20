using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class M_SKILLMAP_CRITERIA : BaseEntity<int>
    {
        public string? Code { get; set; }
        public string Name { get; set; }
        public decimal MaxScore { get; set; }
        public ICollection<M_SKILLMAP_TEMPLATE_DETAIL> M_SkillmapTemplateDetails { get; set; }
        public ICollection<T_SKILLMAP_DETAIL> T_SkillmapDetails { get; set; }
    }
}
