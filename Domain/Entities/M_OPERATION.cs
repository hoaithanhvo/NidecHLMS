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
		public ICollection<OPERATION_DETAIL>? OperationDetails { get; set; }
		public int DepartmentId { get; set; }
		public M_DEPARTMENT? Department { get; set; }
		public int OperationTypeId { get; set; }
		public M_OBJECT? OperationType{get;set;}
		public ICollection<TRAINING_ATTENDEE_DETAIL> TrainingAttendeeDetails { get; set; }
		public ICollection<LEARNING_REPORT> LearningReports { get; set; }

	}
}
