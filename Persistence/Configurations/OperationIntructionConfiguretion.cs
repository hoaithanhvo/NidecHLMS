using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Formats.Tar;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Configurations
{
	public class OperationIntructionConfiguretion : IEntityTypeConfiguration<OperationInstructions>
	{
		public void Configure(EntityTypeBuilder<OperationInstructions> builder)
		{
			builder.ToTable("OperationIntructions");
			builder.HasKey(ot => ot.Id);
			builder.Property(ot => ot.ManagementNumber).HasMaxLength(20);
			builder.Property(ot=>ot.Name).HasMaxLength(500);
			builder.Property(ot=>ot.Note).HasMaxLength(500);
			builder.Property(ot => ot.FileLink).HasMaxLength(50);
			builder.HasOne(ot => ot.Operation).WithMany(o => o.OperationInstruction).HasForeignKey(ot => ot.OperationId);
		}
	}
}
