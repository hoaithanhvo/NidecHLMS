using NidecSystemShared.Abstracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class M_OPERATION : BaseEntity<int>
	{
		public string? OperationCode { get; set; }
		public string? OperationName { get; set; }
		public ICollection<M_TRAINING_CONTENT>? OperationDetails { get; set; }
		public int DepartmentId { get; set; }
		public M_DEPARTMENT? Department { get; set; }
		public int ObjectId { get; set; }
		public M_OBJECT? M_Object{get;set;}
		public ICollection<TRAINING_ATTENDEE_DETAIL> TrainingAttendeeDetails { get; set; }
	}
}
