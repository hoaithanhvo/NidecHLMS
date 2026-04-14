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
	public class M_SESSION_TYPE_Configuration : IEntityTypeConfiguration<M_SESSION_TYPE>
	{
		public void Configure(EntityTypeBuilder<M_SESSION_TYPE> builder)
		{
			builder.Property(mst => mst.SessionNameVI).IsRequired().HasMaxLength(50);
			builder.Property(mst => mst.SessionNameEN).IsRequired().HasMaxLength(50);
			builder.Property(mst => mst.SessionCode).IsRequired().HasMaxLength(20);
		}
	}
}
