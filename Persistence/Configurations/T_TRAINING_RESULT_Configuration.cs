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
	internal class T_TRAINING_RESULT_Configuration : IEntityTypeConfiguration<T_TRAINING_RESULT>
	{
		public void Configure(EntityTypeBuilder<T_TRAINING_RESULT> builder)
		{
			builder.ToTable("T_TRAINING_RESULT");
			builder.HasOne(ttr => ttr.T_TrainingSession).WithMany(ts => ts.T_TrainingResults).HasForeignKey(ttr => ttr.SessionId);

			builder.HasOne(ttr => ttr.M_Operation).WithMany(ts => ts.T_TrainingResults).HasForeignKey(ttr => ttr.OperationId);

			builder.HasOne(ttr => ttr.M_Level).WithMany(ts => ts.T_TrainingResults).HasForeignKey(ttr => ttr.LevelId);

			builder.HasOne(ttr => ttr.M_User).WithMany(ts => ts.T_TrainingResults).HasForeignKey(ttr => ttr.UserId);

			builder.HasOne(ttr => ttr.M_Status).WithMany(ts => ts.T_TrainingResults).HasForeignKey(ttr => ttr.StatusId);
			builder.Property(trr => trr.UserId).IsRequired();
		}
	}
}
