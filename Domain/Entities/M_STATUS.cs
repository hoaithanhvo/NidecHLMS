using Domain.Entities;
using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class M_STATUS : BaseEntity<int>
	{
		public string StatusName { get; set; }
		public string Color { get; set; }
		public string? Description { get; set; }
		public string Type { get; set; }	
		public bool Edit { get; set; }
		public ICollection<M_USER>? Users { get; set; }
		public bool Execute { get; set; }
		public bool View { get; set; }
		public ICollection<T_TRAINING_RESULT>? T_TrainingResults { get; set; }
		public ICollection<T_USER_TRAINING_ENROLLMENT> T_UserTrainingEnrollments { get; set; }
		public ICollection<T_TRAINING_PARTICIPANT> T_TrainingParticipants { get; set; }
		public ICollection<M_TRAINING_CONTENT> M_TrainingContents { get; set; }
		public ICollection<M_TRAINING_CONTENT_STEP> M_TrainingContentSteps { get; set; }
	}
}
