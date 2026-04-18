using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class M_TAG : BaseEntity<int>
	{
		public string TagCode { get; set; }
		public string TagName { get; set; }
		public int Type { get; set; }
		public string? Description { get; set; }
        public ICollection<T_USER_TAG> T_UserTags { get; set; }
    }
}
