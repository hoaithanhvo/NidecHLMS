using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Configurations
{
	public class M_OPERATION_Configuration : IEntityTypeConfiguration<M_OPERATION>
	{
		public void Configure(EntityTypeBuilder<M_OPERATION> builder)
		{
			builder.ToTable("M_OPERATION");
			builder.Property(o => o.OperationCode).HasMaxLength(20).IsRequired();
			builder.Property(o=>o.OperationName).HasMaxLength(200).IsRequired();
			builder.Property(o => o.ManagementNumber).HasMaxLength(50).IsRequired();
			builder.HasOne(o => o.Department).WithMany(d => d.M_Operations).HasForeignKey(o => o.DepartmentId);
			builder.HasOne(o=>o.M_Object).WithMany(ot=>ot.M_Operations).HasForeignKey(o=>o.ObjectId);
			builder.HasOne(o=>o.SkillmapTemplate).WithMany(ot=>ot.M_Operations).HasForeignKey(o=>o.SkillmapTemplateId);
			builder.HasIndex(o => new { o.OperationCode, o.OperationName, o.ManagementNumber }).IsUnique();
		}
	}
}
