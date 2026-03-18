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
	public class TrainingCategoryConfiguration : IEntityTypeConfiguration<TrainingCategories>
	{
		public void Configure(EntityTypeBuilder<TrainingCategories> builder)
		{
			builder.ToTable("TrainingCategories");
			builder.HasKey(tc => tc.Id);
			builder.Property(tc=>tc.Name).HasMaxLength(200).IsRequired();
		}
	}
}
