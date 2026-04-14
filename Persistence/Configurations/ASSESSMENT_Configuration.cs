using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Configurations
{
	public class ASSESSMENT_Configuration : IEntityTypeConfiguration<ASSESSMENT>
	{
		public void Configure(EntityTypeBuilder<ASSESSMENT> builder)
		{
			builder.Property(a => a.AssessmentCode).HasMaxLength(20);

			builder.HasOne(a => a.M_TRAINING_DOCUMENT).WithMany(td => td.Assessments).HasForeignKey(a => a.TrainingDocumentId);
		}
	}
}
