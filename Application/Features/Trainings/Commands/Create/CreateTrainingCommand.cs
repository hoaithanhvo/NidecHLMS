using Application.Interfaces.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Trainings.Commands.Create
{
	public class CreateTrainingCommand : ICommand<int>
	{
		public string ManagementNumber { get; set; }
		public string TrainingContentName { get; set; }
		public int OperationId { get; set; }
		public int LifecycleId { get; set; }
		public string UpdatedBy { get; set; } 
		public string CreatedBy { get; set; }
	}
}
