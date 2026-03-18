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
	public class SkillMapAssessmentConfiguration : IEntityTypeConfiguration<SkillMapAssessments>
	{
		public void Configure(EntityTypeBuilder<SkillMapAssessments> builder)
		{
			builder.ToTable("SkillMapAssessments");
			builder.HasKey(SMA => SMA.Id);
			builder.Property(SMA => SMA.UserId).HasMaxLength(50).IsRequired();
			builder.Property(SMA => SMA.Result).HasMaxLength(50).IsRequired();
			builder.Property(SMA => SMA.EvalutedByUserId).HasMaxLength(50).IsRequired();
			builder.Property(SMA => SMA.ApprovelByUserId).HasMaxLength(50).IsRequired();
			builder.Property(SMA => SMA.FileLink).HasMaxLength(500).IsRequired();
			builder.Property(SMA => SMA.Note).HasMaxLength(500).IsRequired();

			builder.HasOne(SMA => SMA.TrainingRequests).WithMany(tr => tr.SkillMapAssessment).HasForeignKey(SMA => SMA.TrainingResultId);

			builder.HasOne(SMA => SMA.SkillMapCriteria).WithMany(SMC => SMC.SkillMapAssessment).HasForeignKey(SMA => SMA.SkillMapCriterialId);

		}
	}
}
