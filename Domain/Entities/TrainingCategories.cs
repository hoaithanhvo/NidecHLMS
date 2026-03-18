using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class TrainingCategories
	{
		public int Id { get; set; }	
		public string Name { get; set; }
		public string Description { get; set; }	
		public decimal MaxDurationDays {  get; set; }
		public DateTime CreateDate { get; set; }
		public DateTime UpdateDate { get; set; }
		public int CreateBy { get; set; }
		public int UpdateBy { get; set; }
	}
}
