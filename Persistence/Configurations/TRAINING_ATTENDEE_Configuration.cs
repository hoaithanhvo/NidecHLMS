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
	public class TRAINING_ATTENDEE_Configuration : IEntityTypeConfiguration<TRAINING_ATTENDEE>
	{
		public void Configure(EntityTypeBuilder<TRAINING_ATTENDEE> builder)
		{
			builder.Property(ta=>ta.Note).IsRequired().HasMaxLength(200);

			builder.HasOne(ta => ta.M_USER).WithMany(u => u.TrainingAttendees).HasForeignKey(ta => ta.UserId).IsRequired(false);

			builder.HasOne(ta=>ta.TRAINING_DOCUMENT).WithMany(td=>td.TrainingAttendees).HasForeignKey(ta=>ta.TrainingDocumentId);

			builder.HasOne(ta => ta.M_TRAINING_CONTENT).WithMany(od => od.TrainingAttendees).HasForeignKey(ta => ta.OperationId);
		}
	}
}
