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
        public string ExternalCode { get; set; }

        public string FullName { get; set; }
        public string Email { get; set; }

        public string SourceType { get; set; } // Internal / Import / External
    }
}
