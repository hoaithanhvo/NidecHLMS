using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class M_ASSESSMENT : BaseEntity<int>
	{
		public string? AssessmentCode { get; set; }
		public int TrainingDocument_Id { get; set; }
		public M_TRAINING_DOCUMENT? M_TRAINING_DOCUMENT { get; set; }
	}
}
