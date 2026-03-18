using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class Users
	{
		public int Id { get; set; }
		public int IdmUserId { get; set; }
		public string FullName { get; set; }
		public string DivisionCd { get; set; }
		public string Position { get; set; }
		public bool IsActive { get; set; }	
		public string EmployeeId { get; set; }
		public DateTime JoinDate { get; set; }	
		public DateTime CreateDate { get; set; }
		public DateTime UpdateDate { get; set; }
		public int CreateBy { get; set; }
		public int UpdateBy { get; set; } 
	}
}
