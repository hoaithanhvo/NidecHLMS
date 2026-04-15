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
	public class M_TRAINING_CONTENT_TYPE_Configuration : IEntityTypeConfiguration<M_TRAINING_CONTENT_TYPE>
	{
		public void Configure(EntityTypeBuilder<M_TRAINING_CONTENT_TYPE> builder)
		{
			builder.Property(mtct => mtct.ContentTypeNameVI).IsRequired().HasMaxLength(50);
			builder.Property(mtct => mtct.ContentTypeNameEN).IsRequired().HasMaxLength(50);
		}
	}
}
