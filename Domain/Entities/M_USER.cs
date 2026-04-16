using Domain.Entitises;
using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class M_USER : BaseEntity<int>
	{
		public int? IdmUserId { get; set; }
		public string FullName { get; set; }
		public string EmployeeId { get; set; }
		public int StatusId { get; set; }	
		public int DepartmentId { get; set; }
		public bool? IsDeleted { get; set; }	
		public DateTime? DeleteDate	{ get; set; }
		public M_STATUS? Status { get; set; }
		public ICollection<T_TRAINING_ATTENDEE> TrainingAttendees { get; set; }
		public ICollection<LEARNING_REPORT> LearningReports { get; set; }
		public ICollection<T_SKILLMAP> Skillmaps { get; set; }
		public M_DEPARTMENT M_Departments { get; set; }
		public ICollection<T_ASSESSMENT> Assessments { get; set; }
		public ICollection<T_ASSESSMENT_RESULT> T_AssetssmentResults { get; set; }
		public ICollection<T_TRAINING_RESULT> T_TrainingResults { get; set; }
		public ICollection<T_USER_TAG> T_UserTags { get; set; }
        public ICollection<T_USER_ROLE> UserRoles { get; set; }
		public ICollection<T_USER_TRAINING_PROGRESS> T_UserTrainingProcess { get; set; }
	}
}
