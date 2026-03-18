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
	public class DivisionConfiguration : IEntityTypeConfiguration<Divisions>
	{
		public void Configure(EntityTypeBuilder<Divisions> builder)
		{
			builder.ToTable("Divisions");
			builder.HasKey(d => d.Id);
			builder.Property(d => d.DivisionCd).HasMaxLength(20);
			builder.Property(d=>d.DivisionName).HasMaxLength(200);
		}
	}
}
