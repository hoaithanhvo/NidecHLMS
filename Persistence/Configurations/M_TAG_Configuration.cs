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
	public class M_TAG_Configuration : IEntityTypeConfiguration<M_TAG>
	{
		public void Configure(EntityTypeBuilder<M_TAG> builder)
		{
			builder.Property(ht => ht.TagCode).IsRequired().HasMaxLength(20);
			builder.Property(ht=>ht.TagName).IsRequired().HasMaxLength(50);
			builder.Property(ht=>ht.Type).IsRequired().HasMaxLength(20);
			//builder.HasOne(ht => ht.M_LEVEL).WithMany(l => l.M_HATTAGs).HasForeignKey(ht => ht.LevelId);

		}
	}
}
