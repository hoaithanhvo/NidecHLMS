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
	public class M_OPERATION_TYPE_Configuration : IEntityTypeConfiguration<M_OPERATION_TYPE>
	{
		public void Configure(EntityTypeBuilder<M_OPERATION_TYPE> builder)
		{
			builder.ToTable("OPERATION_TYPE");
			builder.Property(ot=>ot.Code).HasMaxLength(20).IsRequired();
			builder.Property(ot=>ot.Name).HasMaxLength(100).IsRequired();

		}
	}
}
