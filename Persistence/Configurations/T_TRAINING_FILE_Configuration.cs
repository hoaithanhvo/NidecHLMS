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
    public class T_TRAINING_FILE_Configuration : IEntityTypeConfiguration<T_TRAINING_FILE>
    {
        public void Configure(EntityTypeBuilder<T_TRAINING_FILE> builder)
        {
			builder.ToTable("T_TRAINING_FILE");
			builder.HasOne(ttf => ttf.T_UserTrainingEnrollment).WithMany(ute => ute.T_TrainingFiles).HasForeignKey(ttf => ttf.EnrollmentId);
            builder.HasOne(ttf => ttf.M_TrainingContentFlow).WithMany(ute => ute.T_TrainingFiles).HasForeignKey(ttf => ttf.TrainingContentFlowId);
            builder.HasOne(ttf => ttf.M_TrainingContentFlowStep).WithMany(ute => ute.T_TrainingFiles).HasForeignKey(ttf => ttf.TrainingContentFlowStepId);
        }
    }
}
