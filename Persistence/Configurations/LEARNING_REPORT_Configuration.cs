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
	public class LEARNING_REPORT_Configuration : IEntityTypeConfiguration<LEARNING_REPORT>
	{
		public void Configure(EntityTypeBuilder<LEARNING_REPORT> builder)
		{
			builder.Property(lr => lr.LeaningReportCode).IsRequired().HasMaxLength(20);
			builder.Property(lr => lr.Trainer).IsRequired().HasMaxLength(50);
			builder.Property(lr => lr.FilePath).IsRequired().HasMaxLength(20);
			builder.Property(lr => lr.Note).HasMaxLength(200);

			builder.HasOne(lr => lr.M_Users).WithMany(u => u.LearningReports).HasForeignKey(lr => lr.UserId);

			builder.HasOne(lr => lr.M_TrainingDocument).WithMany(mo => mo.LearningReports).HasForeignKey(lr => lr.TrainingDocumentId);
		}
	}
}
