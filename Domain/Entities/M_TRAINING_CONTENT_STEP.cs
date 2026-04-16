using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class M_TRAINING_CONTENT_STEP : BaseEntity<int>
	{
		public string StepName { get; set; }
		public int OrderNo { get; set; }
		public ICollection<M_TRAINING_CONTENT> M_TrainingContents { get; set; }
		public ICollection<T_USER_TRAINING_PROGRESS> T_UserTrainingProcess { get; set; }

	}
}
