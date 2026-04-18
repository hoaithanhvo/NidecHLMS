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
	public class T_USER_TRAINING_ENROLLMENT_Configuration : IEntityTypeConfiguration<T_USER_TRAINING_ENROLLMENT>
	{
		public void Configure(EntityTypeBuilder<T_USER_TRAINING_ENROLLMENT> builder)
		{
			builder.HasOne(tute => tute.M_Status).WithMany(u => u.T_UserTrainingEnrollments).HasForeignKey(tute => tute.StatusId);
			builder.HasOne(tute => tute.M_TrainingContent).WithMany(u => u.T_UserTrainingEnrollments).HasForeignKey(tute => tute.TrainingContentId);
			builder.HasOne(tute => tute.M_TrainingContentFlow).WithMany(u => u.T_UserTrainingEnrollments).HasForeignKey(tute => tute.TrainingContentFlowId);
			builder.HasOne(tute => tute.T_TrainingParticipant).WithMany(u => u.T_UserTrainingEnrollments).HasForeignKey(tute => tute.ParticipantId);
			builder.HasIndex(tute => tute.EnrollmentCode).IsUnique();
        }
    }
}
