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
	public class SkillTypeConfiguration : IEntityTypeConfiguration<SkillTypes>
	{
		public void Configure(EntityTypeBuilder<SkillTypes> builder)
		{
			builder.ToTable("SkillTypes");

			builder.HasKey(SK => SK.Id);

			builder.Property(ST => ST.Name).HasMaxLength(200);

			builder.HasOne(ST=>ST.SkillGroup).WithMany(sg=>sg.SkillType).HasForeignKey(ST=>ST.SkillGroupId);
		}
	}
}
