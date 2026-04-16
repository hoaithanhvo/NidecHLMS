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
    public class M_PERMISSION_Configuration : IEntityTypeConfiguration<M_PERMISSION>
    {
        public void Configure(EntityTypeBuilder<M_PERMISSION> builder)
        {
            builder.HasIndex(mp=>mp.PermissionCode).IsUnique();
        }
    }
}
