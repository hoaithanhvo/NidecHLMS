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
	public class M_USER_Configuration : IEntityTypeConfiguration<M_USER>
	{
		public void Configure(EntityTypeBuilder<M_USER> builder)
		{
			builder.ToTable("M_USER");
			builder.Property(u => u.FullName).HasMaxLength(200).IsRequired();
			builder.Property(u => u.EmployeeId).HasMaxLength(50).IsRequired();
			builder.HasIndex(u => u.EmployeeId).IsUnique();
			builder.HasOne(u=>u.Status).WithMany(s=>s.Users).HasForeignKey(u => u.StatusId);
			builder.HasOne(u => u.M_Departments).WithMany(s => s.M_User).HasForeignKey(u => u.DepartmentId);

		}
	}
}
