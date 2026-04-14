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
	public class TRAINING_ATTENDEE_DETAIL_Configuration : IEntityTypeConfiguration<TRAINING_ATTENDEE_DETAIL>
	{
		public void Configure(EntityTypeBuilder<TRAINING_ATTENDEE_DETAIL> builder)
		{
			builder.Property(tad => tad.Note).HasMaxLength(200);

			builder.HasOne(tad => tad.M_STATUS).WithMany(s => s.TrainingAttendeeDetails).HasForeignKey(s => s.StatusId);

			builder.HasOne(tad => tad.TrainingSession).WithMany(ts => ts.TrainingAttendeeDetails).HasForeignKey(s => s.TrainingSessionId);

			builder.HasOne(tad => tad.Assessment).WithMany(ts => ts.TrainingAttendeeDetails).HasForeignKey(s => s.AssessmentId);
		}
	}
}
