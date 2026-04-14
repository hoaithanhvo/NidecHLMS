using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class OPERATION_DETAIL : BaseEntity<int>
	{
		public string? OperationDetailNumber { get; set; }
		public string? TrainingContent { get; set; }
		public int OperationId { get; set; }
		public int OpertionStatusId { get; set; }
		public M_OPERATION? Operation { get; set; }
		public M_OPERATION_STATUS? Operation_Status { get; set; }
		public ICollection<TRAINING_ATTENDEE> TrainingAttendees { get; set; }
		public ICollection<M_SKILLMAP_LEVEL> M_Skillmap_Level { get; set; }	
	}
}
