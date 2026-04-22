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
    public class T_USER_ROLE_Configuration : IEntityTypeConfiguration<T_USER_ROLE>
    {
        public void Configure(EntityTypeBuilder<T_USER_ROLE> builder)
        {
			builder.ToTable("T_USER_ROLE");
			builder.HasOne(tur => tur.Role).WithMany(r => r.UserRoles).HasForeignKey(tur => tur.RoleId);
            builder.HasOne(tur => tur.User).WithMany(r => r.UserRoles).HasForeignKey(tur => tur.UserId);
        }
    }
}
