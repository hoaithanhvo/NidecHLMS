using Domain.Entities;
using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class M_TRAINING_CONTENT : BaseEntity<int>
	{
		public string ManagementNumber { get; set; }
		public string TrainingContentName { get; set; }
		public int OperationId { get; set; }
		public int LifecycleId { get;set; }
		public bool? IsDeleted { get; set; }
		public DateTime? DeleteDate { get; set; }
		public ICollection<M_TRAINING_DOCUMENT> M_TrainingDocuments { get; set; }
		public M_OPERATION M_Operation { get; set; }	
		public M_TRAINING_CONTENT_LIFECYCLE M_TrainingContentLifecycle { get; set; }
		public ICollection<M_HANDOVER_RECORD>? M_HandoverRecords { get; set; }
		public ICollection<T_COURSE_CONTENT> T_CourseContents { get; set; }
		public ICollection<T_USER_TRAINING_PROGRESS> T_UserTrainingProcess { get; set; }
		public ICollection<M_TRAINING_CONTENT_FLOW> T_TrainingContentFlows { get; set; }
	}
}
