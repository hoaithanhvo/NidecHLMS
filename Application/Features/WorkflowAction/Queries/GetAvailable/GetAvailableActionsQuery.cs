using Application.Common.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.WorkflowAction.Queries.GetAvailable
{
	public class GetAvailableActionsQuery : IRequest<List<WorkflowActionDTO>>
	{
		public int EnrollmentId { get; set; }
	}
}
