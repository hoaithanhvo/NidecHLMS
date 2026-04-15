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
	public class M_TRAINING_CONTENT_STEP_Configuration : IEntityTypeConfiguration<M_TRAINING_CONTENT_STEP>
	{
		public void Configure(EntityTypeBuilder<M_TRAINING_CONTENT_STEP> builder)
		{
		}
	}
}
