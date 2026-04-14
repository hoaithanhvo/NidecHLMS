using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class M_SKILLMAP_LEVEL : BaseEntity<int>
	{
		public int OperationDetailId { get; set; }	
		public int Standard { get;set; }
		public string? EnaluationCategoryEN { get; set; }
		public string? EnaluationCategoryVI { get; set; }
		public decimal Coefficient { get; set; }

		public OPERATION_DETAIL  OPERATION_DETAIL { get; set; }
	}
}
