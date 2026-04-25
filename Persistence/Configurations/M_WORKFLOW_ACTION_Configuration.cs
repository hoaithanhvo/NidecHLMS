using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Configurations
{
	public class M_WORKFLOW_ACTION_Configuration : IEntityTypeConfiguration<M_WORKFLOW_ACTION>
	{
		public void Configure(EntityTypeBuilder<M_WORKFLOW_ACTION> builder)
		{
			builder.ToTable("M_WORKFLOW_ACTION");
		}
	}
}
