using Application.Interfaces.Command;
using Application.DTOs.Responses.Trainings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Trainings.Commands.Create
{
	public class CreateTrainingCommand : ICommand<bool>
	{
		public string ManagementNumber { get; set; }
		public string TrainingContentName { get; set; }
		public int OperationId { get; set; }
		public int LifecycleId { get; set; }
	}
}
