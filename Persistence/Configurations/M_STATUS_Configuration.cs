using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Configurations
{

	public class M_STATUS_Configuration : IEntityTypeConfiguration<M_STATUS>
	{
		public void Configure(EntityTypeBuilder<M_STATUS> builder)
		{
			builder.ToTable("M_STATUS");
		}
	}
}
