using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class M_LEVEL : BaseEntity<int>
	{
		public string LevelCode { get; set; }
		public string LevelName { get; set; }
		public int Status { get; set; }
		public string? Type { get; set; }
		public decimal Coefficient { get; set; }

		public ICollection<TRAINING_ATTENDEE_DETAIL> TrainingAttendeeDetails { get; set; }
		public ICollection<M_HATTAG> M_Hattags { get; set; }
		public ICollection<T_SKILLMAP> Skillmaps { get; set; }
		public ICollection<T_TRAINING_RESULT> T_TrainingResult { get; set; }
	}
}
