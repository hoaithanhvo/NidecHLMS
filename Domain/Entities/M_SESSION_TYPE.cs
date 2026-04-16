//using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class M_SESSION_TYPE :BaseEntity<int>
	{
		public string SessionNameVI { get; set; }
		public string SessionNameEN { get; set; }
		public string SessionCode { get; set; }
		public ICollection<T_TRAINING_SESSION> TrainingSessions { get; set; }
	}
}
