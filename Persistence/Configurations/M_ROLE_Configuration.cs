using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    internal class M_ROLE_Configuration : IEntityTypeConfiguration<M_ROLE>
    {
        public void Configure(EntityTypeBuilder<M_ROLE> builder)
        {
			builder.ToTable("M_ROLE");
			builder.HasIndex(mr=>mr.RoleCode).IsUnique();
        }
    }
}
