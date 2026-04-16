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
		public string Code { get; set; }
		public int TrainingContentId { get; set; }
		public bool? IsDeleted { get; set; }
		public DateTime? DeleteDate { get; set; }
		public ICollection<T_ASSESSMENT> Assessments { get; set; }
		public ICollection<LEARNING_REPORT> LearningReports { get; set; }
		public M_TRAINING_CONTENT M_TrainingContent { get; set; }
		
	}
}
