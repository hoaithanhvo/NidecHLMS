using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Configurations
{
	public class M_DEPARTMENT_Configuration : IEntityTypeConfiguration<M_DEPARTMENT>
	{
		public void Configure(EntityTypeBuilder<M_DEPARTMENT> builder)
		{
			builder.ToTable("M_DEPARTMENT");
			builder.Property(dp => dp.Name).HasMaxLength(30).IsRequired();
			builder.Property(dp => dp.Section).HasMaxLength(50).IsRequired();
		}
	}
}
