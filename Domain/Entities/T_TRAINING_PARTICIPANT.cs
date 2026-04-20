using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class T_TRAINING_PARTICIPANT : BaseEntity<int>
    {
        public int Id { get; set; }
        public int? UserId { get; set; } // optional mapping
        public string Code { get; set; }
        public string FullName { get; set; }
        public string? Email { get; set; }
        public int SourceId { get; set; } // Internal / Import / External
        public int StatusId { get; set; }   
		public M_USER M_User { get; set; } 
        public M_SOURCE M_Sources { get; set; }
        public M_STATUS M_Status { get; set; }
        public ICollection<T_USER_TRAINING_ENROLLMENT> T_UserTrainingEnrollments { get; set; }
        public ICollection<T_USER_TAG> T_UserTags { get; set; }
	}
}
