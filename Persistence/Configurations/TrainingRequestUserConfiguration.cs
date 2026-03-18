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
	public class TrainingRequestUserConfiguration : IEntityTypeConfiguration<TrainingRequestUsers>
	{
		public void Configure(EntityTypeBuilder<TrainingRequestUsers> builder)
		{
			builder.ToTable("TrainingRequestUsers");
			builder.HasKey(TRU => TRU.Id);
			builder.HasOne(TRU => TRU.TrainingRequest).WithMany(Tr => Tr.TrainingRequestUser).HasForeignKey(TRU => TRU.TrainingRequestId);
		}
	}
}
