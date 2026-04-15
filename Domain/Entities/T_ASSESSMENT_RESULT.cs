using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class T_ASSESSMENT_RESULT : BaseEntity<int>
	{
		public int AssessmentId { get; set; }
		public int UserId {get;set;}
		public int Score {get;set;}
		public int LevelId { get; set;}
		public int StatusId { get; set;}
		public string Result { get; set; }
		public ASSESSMENT Assessment { get; set; }
		public M_USER M_User { get; set; }
	}
}
