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
	public class M_USER_Configuration : IEntityTypeConfiguration<M_User>
	{
		public void Configure(EntityTypeBuilder<M_User> builder)
		{
			builder.ToTable("M_USER");
			builder.Property(u => u.FullName).HasMaxLength(200).IsRequired();
			builder.Property(u => u.EmployeeId).HasMaxLength(50).IsRequired();
			builder.HasOne(u=>u.Status).WithMany(s=>s.Users).HasForeignKey(u => u.StatusId);
		}
	}
}
