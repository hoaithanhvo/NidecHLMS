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
	public class M_STEP_REQUIREMENT_Configuration : IEntityTypeConfiguration<M_STEP_REQUIREMENT>
	{
		public void Configure(EntityTypeBuilder<M_STEP_REQUIREMENT> builder)
		{
			builder.ToTable("M_STEP_REQUIREMENT");

			builder.HasOne(mtr=>mtr.M_RequirementType).WithMany(r=>r.M_StepRequirements).HasForeignKey(mtr=>mtr.RequirementTypeId).OnDelete(DeleteBehavior.Restrict);

			builder.HasOne(mtr => mtr.M_TrainingContentFlow).WithMany(r => r.M_StepRequirements).HasForeignKey(mtr => mtr.TrainingContentFlowId).OnDelete(DeleteBehavior.Restrict);

			builder.HasOne(mtr => mtr.M_TrainingContentStep).WithMany(r => r.M_StepRequirements).HasForeignKey(mtr => mtr.TrainingContentStepId).OnDelete(DeleteBehavior.Restrict);
		}
	}
}
