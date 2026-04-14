using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class M_OPERATION_LIFECYCLE : BaseEntity<int>
	{
		public bool ConfirmRecurringOperation { get; set; }
		public int RetrainingFrequency { get; set; }
		public string? Description { get; set; }
	}
}
