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
		public int Operation_Id { get; set; }
		public int OpertionStatus_Id { get; set; }
		public M_OPERATION? Operation { get; set; }
		public M_OPERATION_STATUS? Operation_Status { get; set; }
	}
}
