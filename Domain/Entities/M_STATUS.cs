using Domain.Entitises;
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
		public string? StatusName { get; set; }
		public string? Color { get; set; }
		public string? Description { get; set; }
		public string? Type { get; set; }	
		public bool Edit { get; set; }
		public ICollection<M_USER>? Users { get; set; }
		public bool Execute { get; set; }
		public bool View { get; set; }
		public ICollection<TRAINING_ATTENDEE_DETAIL>? TrainingAttendeeDetails { get; set; }
		public ICollection<M_HANDOVER_RECORD>? M_HandoverRecords { get; set; }
	}
}
