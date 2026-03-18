using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class SkillTypes
	{
		public int Id { get; set; }	
		public int SkillGroupId { get; set; }
		public string Name { get; set; }
		public DateTime CreateDate { get; set; }
		public DateTime UpdateDate { get; set; }
		public int CreateBy { get; set; }
		public int UpdateBy { get; set; }

		public ICollection<SkillMapCriteria> SkillMapCriteria { get; set; }
		public SkillGroups SkillGroup { get; set; }
		public ICollection<Operations> Operation { get; set; }
		public ICollection<RetrainingRules> RetrainingRule { get; set; }
	}
}
