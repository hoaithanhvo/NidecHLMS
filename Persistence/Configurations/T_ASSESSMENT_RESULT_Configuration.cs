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
	public class T_ASSESSMENT_RESULT_Configuration : IEntityTypeConfiguration<T_ASSESSMENT_RESULT>
	{
		public void Configure(EntityTypeBuilder<T_ASSESSMENT_RESULT> builder)
		{
			builder.HasOne(ta => ta.Assessment).WithMany(u => u.T_AssetssmentResults).HasForeignKey(ta => ta.AssessmentId).IsRequired(false);

			builder.HasOne(ta => ta.M_User).WithMany(u => u.T_AssetssmentResults).HasForeignKey(ta => ta.UserId).IsRequired(false);
		}
	}
}
