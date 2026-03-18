using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class Certificates
	{
		public uint Id { get; set; }
		public int CetificateId { get; set; } 
		public int UserId { get; set; }
		public int OperationCd { get; set; }
		public int TrainingResultId { get; set; }
		public string CetificateType { get; set; } = null!;
		public DateTime IssueDate { get; set; }
		public DateTime ExpiryDate { get; set; } 
		public string Status { get; set; } = null!;
		public string IssueByUserId { get; set; } = null!;
		public string Note { get; set; } = null!;
		public string FileLink { get; set; } = null!;

		public TrainingResults TrainingResults { get; set; }	

	}
}
