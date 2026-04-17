using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class T_USER_TRAINING_PROGRESS : BaseEntity<int>
	{
		public int UserId {get;set;}
		public int TrainingContentId {get;set;}
		public int TrainingContentStepId { get;set;}
		public int TrainingContentStepFlowId { get;set;}
		public int StatusId { get;set;}
		public DateTime CompleteDate { get;set;}
		public bool? IsDeleted { get; set; }
		public DateTime? DeleteDate { get; set; }
		public M_USER M_User { get;set;}
		public M_TRAINING_CONTENT M_TrainingContent { get;set;}
		public M_TRAINING_CONTENT_STEP M_TrainingContentStep { get;set;}
		public M_TRAINING_CONTENT_FLOW_STEP M_TrainingContentFlowStep { get;set;}
		public M_STATUS M_Status { get;set;}	
	}
}
