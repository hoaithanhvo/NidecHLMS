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
	public class T_SKILLMAP_Configuration : IEntityTypeConfiguration<T_SKILLMAP>
	{
		public void Configure(EntityTypeBuilder<T_SKILLMAP> builder)
		{
			builder.HasOne(sm => sm.Assessments).WithMany(a => a.Skillmaps).HasForeignKey(sm => sm.AssessmentId);

			builder.HasOne(sm => sm.M_Users).WithMany(u => u.Skillmaps).HasForeignKey(sm => sm.IssueBy);

			builder.HasOne(sm => sm.M_Users).WithMany(u => u.Skillmaps).HasForeignKey(sm => sm.ConfirmBy);

			builder.HasOne(sm => sm.M_Users).WithMany(u => u.Skillmaps).HasForeignKey(sm => sm.ApproveBy);
		}
	}
}