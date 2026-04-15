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
	public class T_COURSE_CONTENT_Configuration : IEntityTypeConfiguration<T_COURSE_CONTENT>
	{
		public void Configure(EntityTypeBuilder<T_COURSE_CONTENT> builder)
		{
			builder.HasOne(tcc=>tcc.T_TrainingCourse).WithMany(tc=>tc.T_CourseContents).HasForeignKey(tcc=>tcc.CourseId);
			builder.HasOne(tcc => tcc.M_TrainingContent).WithMany(tc => tc.T_CourseContents).HasForeignKey(tcc => tcc.TrainingContentId);
		}
	}
}
