using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.DTOs
{
	public class TrainingContentDTO
	{
		public int Id { get; set; }
		public string ManagementNumber { get; set; }
		public string TrainingContentName { get; set; }
		public ObjectDTO Object { get; set; }
		public TrainingContentLifeCycleDTO LifeCycle { get; set; }
		public StatusDTO Status { get; set; }
        public string UpdatedBy { get; set; } = string.Empty;
        public string CreatedBy { get; set; } = string.Empty;
    }
}
