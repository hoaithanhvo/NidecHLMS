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
    public class T_SKILLMAP_RESULT_Configuration : IEntityTypeConfiguration<T_SKILLMAP_RESULT>
    {
        public void Configure(EntityTypeBuilder<T_SKILLMAP_RESULT> builder)
        {
			builder.ToTable("T_SKILLMAP_RESULT");
			builder.HasOne(tsr => tsr.T_UserTrainingEnrollment).WithMany(tute => tute.T_SkillmapResults).HasForeignKey(tsr => tsr.EnrollmentId);
            builder.HasOne(tsr => tsr.M_Level).WithMany(ml=>ml.T_SkillmapResults).HasForeignKey(tsr => tsr.Rank);
        }
    }
}
