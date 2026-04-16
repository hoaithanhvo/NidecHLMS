using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class T_FILE_STORAGE : BaseEntity<int>
	{
		public string FileName	{ get; set; }
		public string FilePath { get; set; }
		public string Refid { get; set; }
		public string RefType { get; set; }
	}
}
