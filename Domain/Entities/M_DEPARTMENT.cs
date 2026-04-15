using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class M_DEPARTMENT : BaseEntity<int>
	{
		public string? Name { get; set; }
		public string? Section { get; set; }
		public ICollection<M_OPERATION>? M_Operation { get; set; }
		public ICollection<M_USER>? M_User { get; set; }

	}
}
