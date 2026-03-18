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
	public class SkillMapAssessmentDetailConfiguration : IEntityTypeConfiguration<SkillMapAssessmentDetails>
	{
		public void Configure(EntityTypeBuilder<SkillMapAssessmentDetails> builder)
		{
			builder.HasOne(SMAD => SMAD.SkillMapAssessment).WithMany(SMA => SMA.SkillMapAssessmentDetails).HasForeignKey(SMAD => SMAD.SkillMapAssessmentId);
		}
	}
}
