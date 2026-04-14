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

			builder.HasOne(tad => tad.M_OPERATION).WithMany(o => o.TrainingAttendeeDetails).HasForeignKey(tad => tad.OperationId);

			builder.HasOne(tad => tad.M_LEVEL).WithMany(l => l.TrainingAttendeeDetails).HasForeignKey(tad => tad.LevelId);

			builder.HasOne(tad => tad.M_STATUS).WithMany(s => s.TrainingAttendeeDetails).HasForeignKey(s => s.StatusId);
		}
	}
}
