using Domain.Entities;
using Domain.Entitises;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Configurations
{
	public class M_HANDOVER_RECORD_Configuration : IEntityTypeConfiguration<M_HANDOVER_RECORD>
	{
		public void Configure(EntityTypeBuilder<M_HANDOVER_RECORD> builder)
		{
			builder.HasOne(mhc => mhc.M_TrainingContent).WithMany(u => u.M_HandoverRecords).HasForeignKey(mhc => mhc.TrainingContentId);
			builder.HasOne(mhc => mhc.M_Status).WithMany(u => u.M_HandoverRecords).HasForeignKey(mhc => mhc.StatusId);
		}
	}
}
