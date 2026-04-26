using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class M_REQUIREMENT_TYPE : BaseEntity<int>
	{
		public string Code { get; set; } = default!;   
		public string Name { get; set; } = default!;
		public string? Description { get; set; }
		public bool IsActive { get; set; } = true;
		public int DisplayOrder { get; set; }
		public ICollection<M_STEP_REQUIREMENT> M_StepRequirements { get; set; }
	}
}
