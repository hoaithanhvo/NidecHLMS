using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class LOG_AUDIT_Configuration : IEntityTypeConfiguration<LOG_AUDIT>
    {
        public void Configure(EntityTypeBuilder<LOG_AUDIT> builder)
        {
            builder.ToTable("LOG_AUDIT");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.EntityName)
                   .IsRequired()
                   .HasMaxLength(250);

            builder.Property(x => x.Action)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(x => x.RecordId)
                   .IsRequired();

            builder.Property(x => x.OldData)
                   .HasColumnType("nvarchar(max)");

            builder.Property(x => x.NewData)
                   .HasColumnType("nvarchar(max)");

            builder.HasOne(x => x.M_User).WithMany(u => u.Log_Audits).HasForeignKey(x => x.ActionBy);

            builder.HasIndex(x => new { x.EntityName, x.RecordId });
        }
    }
}
