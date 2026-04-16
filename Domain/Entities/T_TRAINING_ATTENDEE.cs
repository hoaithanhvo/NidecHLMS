using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class T_TRAINING_ATTENDEE : BaseEntity<int>
	{
		public int UserId {get;set;}
		public int TrainingCourseId { get;set;}	
		public int StatusId {get;set;}
		public string Note { get;set;}
		public M_USER M_USER {get;set;}	
		public M_STATUS? M_STATUS {get;set;}
		public bool? IsDeleted { get; set; }
		public DateTime? DeleteDate { get; set; }
		public ICollection<T_TRAINING_SESSION> TrainingSessions { get; set; }
		public T_TRAINING_COURSE T_TrainingCourse { get; set; }	

	}
}
