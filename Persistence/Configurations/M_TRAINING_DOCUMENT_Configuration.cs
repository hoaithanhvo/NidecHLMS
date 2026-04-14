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
	public class M_TRAINING_DOCUMENT_Configuration : IEntityTypeConfiguration<M_TRAINING_DOCUMENT>
	{
		public void Configure(EntityTypeBuilder<M_TRAINING_DOCUMENT> builder)
		{
			builder.Property(td => td.Code).IsRequired().HasMaxLength(20);
			builder.Property(td => td.LearnReport).IsRequired().HasMaxLength(50);
		}
	}
}
