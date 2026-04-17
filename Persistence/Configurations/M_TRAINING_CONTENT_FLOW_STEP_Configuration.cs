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
	public class M_TRAINING_CONTENT_FLOW_STEP_Configuration : IEntityTypeConfiguration<M_TRAINING_CONTENT_FLOW_STEP>
	{
		public void Configure(EntityTypeBuilder<M_TRAINING_CONTENT_FLOW_STEP> builder)
		{
			builder.HasOne(x => x.TrainingContentFlow).WithMany(tcf => tcf.FlowSteps).HasForeignKey(x => x.TrainingContentFlowId);

			builder.HasOne(x => x.TrainingContentStep).WithMany(tcf => tcf.FlowSteps).HasForeignKey(x => x.TrainingContentStepId);
		}
	}
}
