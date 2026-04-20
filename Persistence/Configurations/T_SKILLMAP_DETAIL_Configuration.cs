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
    public class T_SKILLMAP_DETAIL_Configuration : IEntityTypeConfiguration<T_SKILLMAP_DETAIL>
    {
        public void Configure(EntityTypeBuilder<T_SKILLMAP_DETAIL> builder)
        {
            builder.HasOne(tsd=>tsd.T_SkillmapResult).WithMany(tsr=>tsr.T_SkillmapDetails).HasForeignKey(tsd=>tsd.SkillmapResultId);
            builder.HasOne(tsd=>tsd.M_SkillmapCriteria).WithMany(tsr=>tsr.T_SkillmapDetails).HasForeignKey(tsd=>tsd.CriteriaId);
        }
    }
}
