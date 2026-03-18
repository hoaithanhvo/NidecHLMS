using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class RetrainingRules
	{
		public int Id { get; set; }
		public int SkillTypeId { get;set; }
		public int  CyleMonths { get; set; }
		public string AssesmentType { get; set; }
		public string AssesmentMonths { get; set; }
		public string Description { get; set; }
		public bool IsActive { get; set; }	
		public DateTime CreateDate { get; set; }
		public DateTime UpdateDate { get; set; } 
		public int CreateBy { get; set; }
		public int UpdateBy { get; set; }	
		public SkillTypes SkillType { get; set; }
	}
}
