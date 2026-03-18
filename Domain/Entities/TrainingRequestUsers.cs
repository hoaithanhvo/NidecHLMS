using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class TrainingRequestUsers
	{
		public int Id { get; set; }
		public int TrainingRequestId { get; set; }
		public int UserId { get; set; }
		public DateTime CreatedDate { get; set;}
		public TrainingRequests TrainingRequest { get; set; }
	}
}
