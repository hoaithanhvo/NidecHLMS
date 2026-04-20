using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class M_SKILLMAP_TEMPLATE : BaseEntity<int>
    {
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public ICollection<M_SKILLMAP_TEMPLATE_DETAIL> M_SkillmapTemplateDetails { get; set; }
        public ICollection<M_OPERATION> M_Operations { get; set; }
    }
}
