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
	public class RetrainingRuleConfiguration : IEntityTypeConfiguration<RetrainingRules>
	{
		public void Configure(EntityTypeBuilder<RetrainingRules> builder)
		{
			builder.ToTable("RetrainingRules");
			builder.HasKey(rr =>rr.Id);
			builder.Property(rr => rr.AssesmentType).HasMaxLength(30).IsRequired();
			builder.Property(rr=>rr.AssesmentMonths).HasMaxLength(50).IsRequired();
			builder.Property(rr=>rr.Description).HasMaxLength(500).IsRequired();
			builder.HasOne(rr => rr.SkillType).WithMany(st => st.RetrainingRule).HasForeignKey(rr => rr.SkillTypeId);
		}
	}
}
