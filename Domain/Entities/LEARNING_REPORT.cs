////using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class LEARNING_REPORT : BaseEntity<int>
	{
		public int UserId { get; set; }
		public string? LeaningReportCode { get; set; }	
		public string? Note { get; set; }
		public string FilePath { get; set; }	
		public string Trainer { get; set; }
		public int TrainingDocumentId { get; set; }
		public M_USER M_Users { get; set; }
		public M_TRAINING_DOCUMENT M_TrainingDocument { get; set; }
	}

    
}
