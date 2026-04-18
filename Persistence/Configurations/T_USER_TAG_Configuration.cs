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
    public class T_USER_TAG_Configuration : IEntityTypeConfiguration<T_USER_TAG>
    {
        public void Configure(EntityTypeBuilder<T_USER_TAG> builder)
        {
            builder.HasOne(tut => tut.M_Tag).WithMany(u => u.T_UserTags).HasForeignKey(tut => tut.TagId);
            builder.HasOne(tut => tut.T_TrainingParticipant).WithMany(u => u.T_UserTags).HasForeignKey(tut => tut.ParticipantId);
            builder.HasOne(tut => tut.T_UserTrainingEnrollment).WithMany(u => u.T_UserTags).HasForeignKey(tut => tut.UserTrainingEnrollmentId);
        }
    }
}
