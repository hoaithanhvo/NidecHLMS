using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class M_HATTAG : BaseEntity<int>
	{
		public string? HatTagCode { get; set; }
		public string? HatTagName { get; set; }
		public int Type { get; set; }
		public int LevelId { get; set; }
		public M_LEVEL M_LEVEL  { get; set; }
	}
}
