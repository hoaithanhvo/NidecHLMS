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
	public class M_TRAINING_CONTENT_Configuration : IEntityTypeConfiguration<M_TRAINING_CONTENT>
	{
		public void Configure(EntityTypeBuilder<M_TRAINING_CONTENT> builder)
		{
			builder.ToTable("M_TRAINING_CONTENTS");

			builder.Property(od=>od.ManagementNumber).IsRequired().HasMaxLength(20);
			builder.Property(od=>od.TrainingContentName).IsRequired().HasMaxLength(100);

			builder.HasOne(od => od.M_TrainingContentStep).WithMany(o => o.M_TrainingContents).HasForeignKey(o => o.TrainingContentStepId);

			builder.HasOne(od => od.M_TrainingContentType).WithMany(o => o.M_TrainingContent).HasForeignKey(o => o.TrainingContentTypeId);
		}
	}
}
