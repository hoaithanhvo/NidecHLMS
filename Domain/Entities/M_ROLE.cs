using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class M_ROLE : BaseEntity<int>
    {
        public string RoleCode { get; set; }
        public string RoleName { get; set; }

        public ICollection<T_USER_ROLE> UserRoles { get; set; }
        public ICollection<T_ROLE_PERMISSION> RolePermissions { get; set; }
    }
}
