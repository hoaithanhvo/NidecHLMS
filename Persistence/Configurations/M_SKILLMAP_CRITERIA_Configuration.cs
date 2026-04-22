using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class M_SKILLMAP_CRITERIA_Configuration : IEntityTypeConfiguration<M_SKILLMAP_CRITERIA>
    {
		public void Configure(EntityTypeBuilder<M_SKILLMAP_CRITERIA> builder)
		{
			builder.ToTable("M_SKILLMAP_CRITERIA");
		}
    }
}
