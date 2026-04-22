using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.DTOs
{
	public class TrainingContentLifeCycleDTO
    {
		public string Code { get; set; }
		public string Name { get; set; }
		public bool IsRenew { get; set; }
		public int RetrainingFrequency { get; set;}
		public string? FrequencyUnit { get; set; }
		public int OrderNo { get; set; }
		public string Description { get; set; }
		public bool IsActive { get; set; }
	}
}
