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

		public int StatusId  { get; set; }
		
		public ICollection<M_TRAINING_DOCUMENT> M_TrainingDocuments { get; set; }
		public M_STATUS? M_Status { get; set; }
		public M_OPERATION M_Operation { get; set; }	
		public M_TRAINING_CONTENT_LIFECYCLE M_TrainingContentLifecycle { get; set; }
		public ICollection<M_TRAINING_CONTENT_FLOW> T_TrainingContentFlows { get; set; }
		public ICollection<T_USER_TRAINING_ENROLLMENT> T_UserTrainingEnrollments { get; set; }

	}
}
