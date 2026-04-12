using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class M_STATUS : BaseEntity<int>
	{
		public string? StatusName { get; set; }
		public string? Color { get; set; }
		public string? Description { get; set; }
		public string? Type { get; set; }	
		public bool Edit { get; set; }
		public ICollection<M_User>? Users { get; set; }
		public bool Execute { get; set; }
		public bool View { get; set; }
	}
}
