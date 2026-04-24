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
	public class M_TRAINING_CONTENT_STEP_TRANSITION_Configuration : IEntityTypeConfiguration<M_TRAINING_CONTENT_STEP_TRANSITION>
	{
		public void Configure(EntityTypeBuilder<M_TRAINING_CONTENT_STEP_TRANSITION> builder)
		{
			builder.ToTable("M_TRAINING_CONTENT_STEP_TRANSITION");

			builder.HasOne(x => x.FromStep).WithMany(mtcs => mtcs.FromTransitions).HasForeignKey(x => x.FromStepId).OnDelete(DeleteBehavior.Restrict);

			builder.HasOne(x => x.ToStep).WithMany(mtcs => mtcs.ToTransitions).HasForeignKey(x => x.ToStepId).OnDelete(DeleteBehavior.Restrict);

			builder.HasOne(x => x.M_TrainingContentFlow).WithMany(mtcs => mtcs.M_TrainingContentStepTransitions).HasForeignKey(x => x.TrainingContentFlowId).OnDelete(DeleteBehavior.Restrict);

			// ===== Constraints =====

			builder.Property(x => x.ActionCode)
				.IsRequired()
				.HasMaxLength(50);

			builder.Property(x => x.ConditionType)
				.HasMaxLength(50);

			builder.Property(x => x.ConditionValue)
				.HasMaxLength(100);

			builder.HasIndex(x => new { x.FromStepId, x.ActionCode, x.TrainingContentFlowId })
	.HasDatabaseName("IX_Transition_FromStep_Action_Flow");


			builder.HasIndex(x => new { x.FromStepId, x.ActionCode, x.ToStepId, x.TrainingContentFlowId })
	.IsUnique()
	.HasFilter("[TrainingContentFlowId] IS NOT NULL");

			builder.HasIndex(x => new { x.FromStepId, x.ActionCode, x.ToStepId })
	.IsUnique()
	.HasFilter("[TrainingContentFlowId] IS NULL");
		}
	}
}
