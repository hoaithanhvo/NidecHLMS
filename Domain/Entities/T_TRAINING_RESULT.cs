using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class T_TRAINING_RESULT : BaseEntity<int>
	{
		public int SessionId { get; set; }
		public int OperationId { get; set; }
		public int LevelId { get; set; }
		public int Score { get; set;}
		public int StatusId { get; set; }
		public int UserId { get; set; }
		public T_TRAINING_SESSION T_TrainingSession { get; set; }
		public M_OPERATION M_Operation { get; set; }
		public M_LEVEL M_Level { get; set; }	
		public M_USER M_User { get; set; }
		public M_STATUS M_Status { get; set; }
	}
}
