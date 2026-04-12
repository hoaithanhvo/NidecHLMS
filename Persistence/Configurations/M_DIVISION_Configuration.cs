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
	public class M_DIVISION_Configuration : IEntityTypeConfiguration<M_DIVISION>
	{
		public void Configure(EntityTypeBuilder<M_DIVISION> builder)
		{
			builder.ToTable("M_DIVISION");
			builder.Property(d => d.DivisionCd).HasMaxLength(20);
			builder.Property(d=>d.DivisionName).HasMaxLength(200);
		}
	}
}
