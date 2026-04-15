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
		public string? ManagementNumber { get; set; }
		public string? TrainingContentName { get; set; }
		public int TrainingContentStepId { get; set; }
		public int TrainingContentTypeId { get; set; }	
		public ICollection<TRAINING_ATTENDEE> TrainingAttendees { get; set; }
		public M_TRAINING_CONTENT_STEP M_TrainingContentStep { get; set; }
		public M_TRAINING_CONTENT_TYPE M_TrainingContentType { get; set; }
		public ICollection<M_TRAINING_DOCUMENT> M_TrainingDocuments { get; set; }

	}
}
