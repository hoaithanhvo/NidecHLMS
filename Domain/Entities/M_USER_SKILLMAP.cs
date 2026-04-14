using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class M_USER_SKILLMAP : BaseEntity<int>
	{
		public int UserId { get; set; }
		public int OperationDetailId { get; set; }	

		public string? Note { get; set; }

		public OPERATION_DETAIL? Operation_Detail { get; set; }	
		
	}
}
