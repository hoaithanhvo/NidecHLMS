using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class SkillMapCriteria
	{
		public int Id { get; set; }
		public int SkillTypeId {get;set;}
		public int CriteriaOrder { get; set; }
		public string Name { get; set; }	
		public decimal MaxScore { get; set; }
		public decimal Coefficient { get; set; }
		public DateTime CreatedDate { get; set; }
		public string CreateBy { get; set; }
		public DateTime UpdateDate { get; set; }
		public string UpdateBy { get; set; }	
		public ICollection<SkillMapAssessments> SkillMapAssessment { get; set; }

		public SkillTypes SkillType { get; set; } 
	}
}
