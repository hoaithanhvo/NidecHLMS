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
	public class SkillGroupsConfiguration : IEntityTypeConfiguration<SkillGroups>
	{
		public void Configure(EntityTypeBuilder<SkillGroups> builder)
		{
			builder.ToTable("SkillGroups");
			builder.HasKey(x => x.Id);
			builder.Property(SG => SG.Name).HasMaxLength(200).IsRequired();
		}
	}
}
