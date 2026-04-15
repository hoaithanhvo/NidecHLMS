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
	public class TRAINING_ATTENDEE_Configuration : IEntityTypeConfiguration<T_TRAINING_ATTENDEE>
	{
		public void Configure(EntityTypeBuilder<T_TRAINING_ATTENDEE> builder)
		{
			builder.Property(ta=>ta.Note).IsRequired().HasMaxLength(200);

			builder.HasOne(ta => ta.M_USER).WithMany(u => u.TrainingAttendees).HasForeignKey(ta => ta.UserId).IsRequired(false);

			builder.HasOne(ta => ta.T_TrainingCourse).WithMany(u => u.TrainingAttendees).HasForeignKey(ta => ta.TrainingCourseId).IsRequired(false);

			builder.HasOne(ta => ta.M_STATUS).WithMany(u => u.TrainingAttendees).HasForeignKey(ta => ta.StatusId).IsRequired(false);
		}
	}
}
