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
	public class TrainingResultConfiguration : IEntityTypeConfiguration<TrainingResults>
	{
		public void Configure(EntityTypeBuilder<TrainingResults> builder)
		{
			builder.ToTable("TrainingResults");
			builder.HasKey(tr => tr.Id);
			builder.Property(tr => tr.EvaluatedByUserId).HasMaxLength(50).IsRequired();
			builder.Property(tr => tr.TheoryScore).IsRequired();
			builder.Property( tr => tr.PracticeScore).IsRequired();
			builder.Property(tr => tr.Result).HasMaxLength(20);
			builder.Property(tr => tr.EvaluatedByUserId).HasMaxLength(50);
			builder.Property(tr => tr.Note).HasMaxLength(500).IsRequired();

			builder.HasOne(tr=>tr.TrainingSessions).WithMany(
t=>t.TrainingResults).HasForeignKey(t=>t.TrainingSessionId); 
		}
	}
}
