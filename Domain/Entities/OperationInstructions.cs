using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class OperationInstructions
	{
		public int Id { get; set; }	
		public string ManagementNumber { get; set; }	
		public int OperationId { get; set; }
		public string Name { get; set; }
		public string FileLink { get; set; }	
		public string Note { get; set; }
		public bool IsActive { get; set; }	
		public DateTime CreateDate { get; set; }
		public DateTime UpdateDate { get; set; }
		public int CreateBy { get; set; }
		public int UpdateBy { get; set; }
		public Operations Operation { get; set; }	
	}
}
