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
	public class SkillMapCriteriaConfiguration : IEntityTypeConfiguration<SkillMapCriteria>
	{
		public void Configure(EntityTypeBuilder<SkillMapCriteria> builder)
		{
			builder.ToTable("SkillMapCriteria");
			builder.HasKey(SMC => SMC.Id);
			builder.Property(SMC => SMC.Name).HasMaxLength(500).IsRequired();

			builder.HasOne(SMC => SMC.SkillType).WithMany(st => st.SkillMapCriteria).HasForeignKey(SMC => SMC.SkillTypeId);
		}
	}
}
