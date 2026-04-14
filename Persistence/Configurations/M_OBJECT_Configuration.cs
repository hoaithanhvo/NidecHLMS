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
	public class M_OBJECT_Configuration : IEntityTypeConfiguration<M_OBJECT>
	{
		public void Configure(EntityTypeBuilder<M_OBJECT> builder)
		{
			builder.ToTable("M_OBJECT");
			builder.Property(ot=>ot.Code).HasMaxLength(20).IsRequired();
			builder.Property(ot=>ot.Name).HasMaxLength(100).IsRequired();
		}
	}
}
