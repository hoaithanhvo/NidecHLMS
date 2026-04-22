using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NidecSystemShared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Configurations
{
	public class T_TRAINING_PARTICIPANT_Configuration : IEntityTypeConfiguration<T_TRAINING_PARTICIPANT>
	{
		public void Configure(EntityTypeBuilder<T_TRAINING_PARTICIPANT> builder)
		{
			builder.ToTable("T_TRAINING_PARTICIPANT");
			builder.Property(ttp => ttp.Code).IsRequired().HasMaxLength(50);

			builder.HasIndex(ttp => ttp.Code).IsUnique();

			builder.HasOne(ttp=>ttp.M_User).WithMany(u=>u.T_TrainingParticipants).HasForeignKey(ttp=>ttp.UserId);

			builder.HasOne(ttp => ttp.M_Sources).WithMany(u => u.T_TrainingParticipants).HasForeignKey(ttp => ttp.SourceId);

			builder.HasOne(ttp => ttp.M_Status).WithMany(u => u.T_TrainingParticipants).HasForeignKey(ttp => ttp.StatusId);
		}
	}
}