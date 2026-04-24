using NidecSystemShared.Abstracts;

namespace Domain.Entities
{
	/// <summary>
	/// Represents an audit trail of data changes for any entity in the database
	/// </summary>
	public class LOG_AUDIT : BaseEntity<long>
	{
		// ===== WHO =====
		public int? ParticipantId { get; set; }

		// ===== WHAT =====
		public string EntityName { get; set; } = string.Empty; // T_USER_TRAINING_ENROLLMENT
		public int RecordId { get; set; }
		public int UserAction { get;	set;}
		public string Action { get; set; } = string.Empty; // CREATE / UPDATE / DELETE

		// ===== DATA =====
		public string? OldData { get; set; } // JSON
		public string? NewData { get; set; } // JSON

		// ===== CONTEXT =====
		public string? Module { get; set; } // LMS / HR / AUTH
		public string? ApiName { get; set; }
		public string? ScreenName { get; set; }

		// ===== TRACE =====
		public string? IPAddress { get; set; }
		public string? Device { get; set; }

		public M_USER M_User { get; set; }	
	}
}
