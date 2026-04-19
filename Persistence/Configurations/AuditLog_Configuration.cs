using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class AuditLog_Configuration : IEntityTypeConfiguration<AUDITLOG>
    {
        public void Configure(EntityTypeBuilder<AUDITLOG> builder)
        {
            builder.ToTable("T_AUDIT_LOG");
            
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Entity)
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

            builder.HasIndex(x => new { x.Entity, x.RecordId });
        }
    }
}
