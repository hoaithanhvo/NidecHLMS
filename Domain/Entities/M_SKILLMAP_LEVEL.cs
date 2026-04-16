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
		public string EvaluationCategoryEN { get; set; }
		public string EvaluationCategoryVI { get; set; }
		public decimal Coefficient { get; set; }
	}
}
