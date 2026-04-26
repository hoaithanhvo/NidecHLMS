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
	public class M_REQUIREMENT_TYPE_Configuration : IEntityTypeConfiguration<M_REQUIREMENT_TYPE>
	{
		public void Configure(EntityTypeBuilder<M_REQUIREMENT_TYPE> builder)
		{
			builder.ToTable("M_REQUIREMENT_TYPE");
			builder.Property(x => x.Code)
		   .HasMaxLength(50)
		   .IsRequired();

			builder.HasIndex(x => x.Code)
				.IsUnique();

			builder.Property(x => x.Name)
				.HasMaxLength(100)
				.IsRequired();

			builder.Property(x => x.Description)
				.HasMaxLength(255);

			builder.Property(x => x.DisplayOrder)
				.HasDefaultValue(1);

			builder.Property(x => x.IsActive)
				.HasDefaultValue(true);
		}
	}
}
