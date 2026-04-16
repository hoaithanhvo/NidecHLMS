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
			builder.Property(o => o.OperationCode).HasMaxLength(10).IsRequired();
			builder.Property(o=>o.OperationName).HasMaxLength(200).IsRequired();
			builder.HasOne(o => o.Department).WithMany(d => d.M_Operation).HasForeignKey(o => o.DepartmentId);
			builder.HasOne(o=>o.M_Object).WithMany(ot=>ot.M_Operations).HasForeignKey(o=>o.ObjectId);
			builder.HasIndex(o => o.OperationCode).IsUnique();	
		}
	}
}
