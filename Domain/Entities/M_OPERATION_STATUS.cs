using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class M_OPERATION_STATUS : BaseEntity<int>
	{
		public string? OperationCode { get; set; }
		public string? OperationName { get; set; }
		public ICollection<OPERATION_DETAIL>? Operation_Details { get; set; }
	}
}
