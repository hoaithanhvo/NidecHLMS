//using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class T_TRAINING_COURSE : BaseEntity<int>
	{
		public string CourseName { get; set; }
		public DateTime StartDate { get; set; }	
		public DateTime EndDate { get; set; }	

		public ICollection<T_TRAINING_ATTENDEE> TrainingAttendees { get; set; }	
		public ICollection<T_COURSE_CONTENT> T_CourseContents { get; set; }
	}
}
