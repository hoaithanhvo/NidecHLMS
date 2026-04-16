using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class T_USER_TAG : BaseEntity<int>
    {
        public int UserId { get; set; }
        public int TagId { get; set; }
        public DateTime AchievedDate { get; set; }
        public M_USER M_User { get; set; }
        public M_TAG M_Tag { get; set; }
    }
}
