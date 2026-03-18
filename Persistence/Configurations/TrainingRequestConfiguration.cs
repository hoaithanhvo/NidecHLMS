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
	public class TrainingRequestConfiguration : IEntityTypeConfiguration<TrainingRequests>
	{
		public void Configure(EntityTypeBuilder<TrainingRequests> builder)
		{
			builder.ToTable("TrainingRequests");
			builder.HasKey(x => x.Id);
			builder.Property(tr => tr.Reason).HasMaxLength(500).IsRequired();
			builder.Property(tr => tr.Status).HasMaxLength(20).IsRequired();
			builder.Property(tr => tr.Note).HasMaxLength(500).IsRequired();

		}
	}
}
