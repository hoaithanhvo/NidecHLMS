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
	public class TrainingSessionConfiguration : IEntityTypeConfiguration<TrainingSessions>
	{
		public void Configure(EntityTypeBuilder<TrainingSessions> builder)
		{
			builder.ToTable("TrainingSessions");
			builder.HasKey(t => t.Id);
			builder.Property(t => t.TrainingPhase).HasMaxLength(30).IsRequired();
			builder.Property(t => t.TrainingCategoryId).IsRequired();
			builder.Property(t=>t.Location).HasMaxLength(200).IsRequired();
			builder.Property(t => t.Status).HasMaxLength(20).IsRequired();
			builder.Property(t => t.Note).HasMaxLength(500).IsRequired();

			builder.HasOne(ts=>ts.TrainingRequest).WithMany(trq=>trq.TrainingSessions).HasForeignKey(ts=>ts.TrainingRequestId);
		}
	}
}
