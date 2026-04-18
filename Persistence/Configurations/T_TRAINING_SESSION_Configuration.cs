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
	public class T_TRAINING_SESSION_Configuration : IEntityTypeConfiguration<T_TRAINING_SESSION>
	{
		public void Configure(EntityTypeBuilder<T_TRAINING_SESSION> builder)
		{
			builder.HasOne(ts => ts.M_SESSION_TYPE).WithMany(mst => mst.TrainingSessions).HasForeignKey(ts => ts.SessionTypeId);

			builder.HasOne(ts => ts.TrainingAttendees).WithMany(mst => mst.TrainingSessions).HasForeignKey(ts => ts.TrainingAttendeeId);
		}
	}
}
