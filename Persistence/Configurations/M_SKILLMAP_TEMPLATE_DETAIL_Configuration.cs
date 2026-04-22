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
    public class M_SKILLMAP_TEMPLATE_DETAIL_Configuration : IEntityTypeConfiguration<M_SKILLMAP_TEMPLATE_DETAIL>
    {
        public void Configure(EntityTypeBuilder<M_SKILLMAP_TEMPLATE_DETAIL> builder)
        {

			builder.ToTable("M_SKILLMAP_TEMPLATE_DETAIL");

			builder.HasOne(mstd=>mstd.M_SkillmapTemplate).WithMany(mst=>mst.M_SkillmapTemplateDetails).HasForeignKey(mstd=>mstd.TemplateId);
            builder.HasOne(mstd=>mstd.M_SkillmapCriteria).WithMany(mst=>mst.M_SkillmapTemplateDetails).HasForeignKey(mstd=>mstd.CriteriaId);
        }
    }
}
