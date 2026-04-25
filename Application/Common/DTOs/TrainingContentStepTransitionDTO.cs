using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.DTOs
{
	public class TrainingContentStepTransitionDTO
	{
		public int? TrainingContentFlowId { get; set; }

		public int FromStepId { get; set; }
		public int ToStepId { get; set; }
		public int ActionCode { get; set; }
	}
}
