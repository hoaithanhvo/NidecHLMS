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
	public class UserConfiguration : IEntityTypeConfiguration<Users>
	{
		public void Configure(EntityTypeBuilder<Users> builder)
		{
			builder.ToTable("Users");
			builder.HasKey( u=> u.Id);
			builder.Property(u => u.FullName).HasMaxLength(200).IsRequired();
			builder.Property(u => u.DivisionCd).HasMaxLength(20).IsRequired();
			builder.Property(u => u.Position).HasMaxLength(100).IsRequired();
			builder.Property(u => u.EmployeeId).HasMaxLength(50).IsRequired();
		}
	}
}
