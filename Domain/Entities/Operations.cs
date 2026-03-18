using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class Operations
	{
		public int Id { get; set; }
		public string OperationCd { get; set; }
		public string Name { get; set; }
		public int SkillTypedId { get; set; }
		public string DivisionCd { get; set; }
		public bool IsActive { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime UpdateDate { get; set; }
		public int CreateBy { get; set; }
		public int UpdateBy { get; set; }
		public bool IsSpecial { get; set; }
		public string ManagementNumber { get; set; }
		public SkillTypes SkillType { get; set; }	
		public ICollection<OperationInstructions> OperationInstruction { get; set; }	

	}
}
