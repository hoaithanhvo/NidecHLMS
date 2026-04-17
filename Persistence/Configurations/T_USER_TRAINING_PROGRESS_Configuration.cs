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
	public class T_USER_TRAINING_PROGRESS_Configuration : IEntityTypeConfiguration<T_USER_TRAINING_PROGRESS>
	{
		public void Configure(EntityTypeBuilder<T_USER_TRAINING_PROGRESS> builder)
		{
			builder.HasOne(tutp => tutp.M_User).WithMany(u => u.T_UserTrainingProcess).HasForeignKey(tutp => tutp.UserId);

			builder.HasOne(tutp => tutp.M_TrainingContent).WithMany(u => u.T_UserTrainingProcess).HasForeignKey(tutp => tutp.TrainingContentId);

			builder.HasOne(tutp => tutp.M_TrainingContentStep).WithMany(u => u.T_UserTrainingProcess).HasForeignKey(tutp => tutp.TrainingContentStepId);

			builder.HasOne(tutp => tutp.M_Status).WithMany(u => u.T_UserTrainingProcess).HasForeignKey(tutp => tutp.StatusId);
		}
	}
}
