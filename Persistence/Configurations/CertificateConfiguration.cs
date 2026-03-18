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
	public class CertificateConfiguration : IEntityTypeConfiguration<Certificates>
	{
		public void Configure(EntityTypeBuilder<Certificates> builder)
		{
			builder.ToTable("Certificates");

			builder.HasKey(x => x.Id);

			builder.Property(x=>x.CetificateId).IsRequired();

			//builder.HasOne<TrainingResults>().WithMany().HasForeignKey(c=>c.TrainingResultId);

			builder.HasOne(c => c.TrainingResults).WithMany(x => x.Certificates).HasForeignKey(c => c.TrainingResultId);

		}
	}
}
