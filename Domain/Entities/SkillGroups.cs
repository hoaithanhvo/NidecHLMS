using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class SkillGroups 
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int ChildId { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime UpdatedDate { get; set; }
		public int CreateBy { get; set; }
		public int UpdateBy { get; set; }	
		public ICollection<SkillTypes> SkillType { get; set; }
	}
}
