using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class M_TRAINING_DOCUMENT:BaseEntity<int>
	{
		public string? Code { get; set; }
		public string? LearnReport { get; set; }
		public ICollection<M_ASSESSMENT>? Assessments { get; set; }
		public ICollection<TRAINING_ATTENDEE>? TrainingAttendees { get; set; }
	}
}
