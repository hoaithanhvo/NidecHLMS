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
	public class OperationsConfiguration : IEntityTypeConfiguration<Operations>
	{
		public void Configure(EntityTypeBuilder<Operations> builder)
		{
			builder.ToTable("Operations");
			builder.HasKey(o => o.Id);
			builder.Property(o=>o.OperationCd).HasMaxLength(20).IsRequired();
			builder.Property(o => o.Name).HasMaxLength(500);
			builder.Property(o => o.DivisionCd).HasMaxLength(20).IsRequired();
			builder.Property(o => o.ManagementNumber).HasMaxLength(50).IsRequired();
			builder.HasOne(o => o.SkillType).WithMany(st => st.Operation).HasForeignKey(o => o.SkillTypedId);
		}
	}
}
