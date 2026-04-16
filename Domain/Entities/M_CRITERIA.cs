using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class M_CRITERIA : BaseEntity<int>
	{
		public string Experianced { get;set; }
		public int MaxPoint { get; set; }	
		public int MinPoint { get; set; }	
		public string? Acction { get; set; }	
	}
}
