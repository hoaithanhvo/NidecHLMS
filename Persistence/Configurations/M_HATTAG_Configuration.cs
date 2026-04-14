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
	public class M_HATTAG_Configuration : IEntityTypeConfiguration<M_HATTAG>
	{
		public void Configure(EntityTypeBuilder<M_HATTAG> builder)
		{
			builder.Property(ht => ht.HatTagCode).IsRequired().HasMaxLength(20);
			builder.Property(ht=>ht.HatTagName).IsRequired().HasMaxLength(50);
			builder.Property(ht=>ht.Type).IsRequired().HasMaxLength(20);
			builder.HasOne(ht => ht.M_LEVEL).WithMany(l => l.M_HATTAGs).HasForeignKey(ht => ht.LevelId);

		}
	}
}
