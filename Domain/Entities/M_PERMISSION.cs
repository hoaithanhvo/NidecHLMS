using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class M_PERMISSION : BaseEntity<int>
    {
        public string PermissionCode { get; set; }
        public string PermissionName { get; set; }

        public ICollection<T_ROLE_PERMISSION> RolePermissions { get; set; }

    }
}
