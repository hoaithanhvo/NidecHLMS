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
	public class TRAINING_ATTENDEE_SESSION_Confifuration : IEntityTypeConfiguration<TRAINING_ATTENDEE_SESSION>
	{
		public void Configure(EntityTypeBuilder<TRAINING_ATTENDEE_SESSION> builder)
		{
			builder.HasOne(ts=>ts.TRAINING_ATTENDEE).WithMany(ta=>ta.TrainingSessions).HasForeignKey(ts=>ts.TrainingAttendeeId);

			builder.HasOne(ts => ts.M_SESSION_TYPE).WithMany(mst => mst.TrainingSessions).HasForeignKey(ts => ts.SessionTypeId);
		}
	}
}
