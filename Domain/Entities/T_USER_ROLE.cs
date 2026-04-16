using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public  class T_USER_ROLE : BaseEntity<int>
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }

        public M_USER User { get; set; }
        public M_ROLE Role { get; set; }
    }
}
