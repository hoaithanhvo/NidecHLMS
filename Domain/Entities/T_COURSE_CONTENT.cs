using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class T_COURSE_CONTENT : BaseEntity<int>
	{
		public int CourseId { get; set; }
		public int TrainingContentId { get; set; }	
		public T_TRAINING_COURSE T_TrainingCourse { get; set; }
		public M_TRAINING_CONTENT M_TrainingContent { get; set; }
	}
}
