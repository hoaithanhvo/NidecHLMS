using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class T_ROLE_PERMISSION : BaseEntity<int>
    {
        public int RoleId { get; set; }
        public int PermissionId { get; set; }
        public M_ROLE Role { get; set; }
        public M_PERMISSION Permission { get; set; }
    }
}
