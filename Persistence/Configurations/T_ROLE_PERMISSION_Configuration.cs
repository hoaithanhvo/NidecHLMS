using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Configurations
{
    public class T_ROLE_PERMISSION_Configuration : IEntityTypeConfiguration<T_ROLE_PERMISSION>
    {
        public void Configure(EntityTypeBuilder<T_ROLE_PERMISSION> builder)
        {
            builder.HasOne(trp => trp.Role).WithMany(r => r.RolePermissions).HasForeignKey(trp => trp.RoleId);
            builder.HasOne(trp => trp.Permission).WithMany(r => r.RolePermissions).HasForeignKey(trp => trp.PermissionId);
        }
    }
}
