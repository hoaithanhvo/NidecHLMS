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
	public class M_SOURCE_Configuration : IEntityTypeConfiguration<M_SOURCE>
	{
		public void Configure(EntityTypeBuilder<M_SOURCE> builder)
		{
			builder.ToTable("M_SOURCE");
		}
	}
}
