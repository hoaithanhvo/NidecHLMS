using NidecSystemShared.Abstracts;

namespace Domain.Entities
{
    /// <summary>
    /// Represents an audit trail of data changes for any entity in the database
    /// </summary>
    public class AUDITLOG : BaseEntity<int>
    {
        public string Entity { get; set; } = string.Empty;
        public int RecordId { get; set; }
        public string Action { get; set; } = string.Empty;
        public string? OldData { get; set; }
        public string? NewData { get; set; }
    }
}
