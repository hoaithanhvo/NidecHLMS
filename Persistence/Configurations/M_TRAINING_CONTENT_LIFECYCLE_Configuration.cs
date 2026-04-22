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
	public class M_TRAINING_CONTENT_LIFECYCLE_Configuration : IEntityTypeConfiguration<M_TRAINING_CONTENT_LIFECYCLE>
	{
		public void Configure(EntityTypeBuilder<M_TRAINING_CONTENT_LIFECYCLE> builder)
		{
			builder.ToTable("M_TRAINING_CONTENT_LIFECYCLE");
		}
	}
}
