using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class TRAINING_ATTENDEE : BaseEntity<int>
	{
		public int UserId {get;set;}
		public int OperationId { get;set;}
		public int TrainingDocumentId { get;set;}	
		public int StatusId {get;set;}
		public string Note { get;set;}
		public M_USER? M_USER {get;set;}	
		public OPERATION_DETAIL? OPERATION_DETAIL {get;set;}
		public M_TRAINING_DOCUMENT? TRAINING_DOCUMENT {get;set;}	
		public M_STATUS? M_STATUS {get;set;}
		public ICollection<TRAINING_ATTENDEE_SESSION> Sessions { get; set; }
		public ICollection<TRAINING_ATTENDEE_SESSION> TrainingSessions { get; set; }
	}
}
