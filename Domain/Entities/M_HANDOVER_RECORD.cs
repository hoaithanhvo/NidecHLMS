using Domain.Entities;
using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class M_HANDOVER_RECORD : BaseEntity<int>
	{
		public DateTime TrainingDay { get; set; }
		public DateTime TransferDate { get; set; }
		public int TrainingContentId { get; set; }
		public int StatusId { get; set; }
		public string? Note { get; set; }
		public M_TRAINING_CONTENT M_TrainingContent {get;set;}
		public M_STATUS M_Status { get; set; }
	}
}
