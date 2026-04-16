using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class M_TRAINING_CONTENT_LIFECYCLE : BaseEntity<int>
	{
		public bool IsRenew { get; set; }
		public int RetrainingFrequency { get; set; }
		public string? Description { get; set; }
		public ICollection<M_TRAINING_CONTENT> M_TrainingContents { get; set; }
	}
}
