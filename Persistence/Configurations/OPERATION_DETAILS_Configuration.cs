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
	public class OPERATION_DETAILS_Configuration : IEntityTypeConfiguration<OPERATION_DETAIL>
	{
		public void Configure(EntityTypeBuilder<OPERATION_DETAIL> builder)
		{
			builder.ToTable("OPERATION_DETAIL");

			builder.Property(od=>od.TrainingContent).IsRequired().HasMaxLength(200);
			builder.Property(od=>od.OperationDetailNumber).IsRequired().HasMaxLength(50);

			builder.HasOne(od=>od.Operation).WithMany(o=>o.OperationDetails).HasForeignKey(o=>o.OperationId);

			builder.HasOne(od => od.Operation_Status).WithMany(os => os.Operation_Details).HasForeignKey(od => od.OpertionStatusId);
		}
	}
}
