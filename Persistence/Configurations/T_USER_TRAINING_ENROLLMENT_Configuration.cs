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
			builder.HasOne(tute => tute.M_Status).WithMany(u => u.T_UserTrainingEnrollment).HasForeignKey(tute => tute.StatusId);

			builder.HasOne(tute => tute.M_TrainingContent).WithMany(u => u.T_UserTrainingEnrollment).HasForeignKey(tute => tute.TrainingContentId);

			builder.HasOne(tute => tute.M_TrainingContentStep).WithMany(u => u.T_UserTrainingEnrollment).HasForeignKey(tute => tute.CurrentStepId);

			builder.HasOne(tute => tute.M_TrainingContentFlowStep).WithMany(u => u.T_UserTrainingEnrollment).HasForeignKey(tute => tute.CurrentFlowStepId);
		}
	}
}
