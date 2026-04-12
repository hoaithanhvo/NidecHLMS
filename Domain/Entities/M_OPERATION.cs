using NidecSystemShared.Abstracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class M_OPERATION : BaseEntity<int>
	{
		public string? OperationCode { get; set; }
		public string? OperationName { get; set; }
		public ICollection<OPERATION_DETAIL>? OperationDetails { get; set; }
		public int Department_Id { get; set; } = 1;
		public M_DEPARTMENT? Department { get; set; }
		public int OperationType_Id { get; set; } = 1;
		public M_OPERATION_TYPE? Operation_Type{get;set;}
	}
}
