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
			builder.ToTable("M_TRAINING_CONTENT");

			builder.Property(od=>od.ManagementNumber).IsRequired().HasMaxLength(20);
			builder.Property(od=>od.TrainingContentName).IsRequired().HasMaxLength(100);

			builder.HasOne(mtc => mtc.M_Operation).WithMany(o => o.M_TrainingContents).HasForeignKey(mtc => mtc.OperationId);

			builder.HasOne(mtc => mtc.M_TrainingContentLifecycle).WithMany(o => o.M_TrainingContents).HasForeignKey(mtc => mtc.LifecycleId);
		}
	}
}
