using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class M_User : BaseEntity<int>
	{
		public int? IdmUserId { get; set; }
		public string? FullName { get; set; }
		public string? EmployeeId { get; set; }
		public int StatusId { get; set; }	
		public M_STATUS? Status { get; set; }
	}
}
