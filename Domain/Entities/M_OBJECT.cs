//using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class M_OBJECT : BaseEntity<int>
	{
		public string? Code { get; set; }
		public string? Name { get; set; }
		public ICollection<M_OPERATION>? M_Operations { get; set; }	 
	}
}
