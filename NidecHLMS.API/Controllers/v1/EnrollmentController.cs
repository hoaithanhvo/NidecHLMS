using Application.Features.Enrollments.Commands.ExecuteEnrollment;
using Application.Features.Enrollments.Commands.RegisterEnrollment;
using Application.Features.Trainings.Commands.Create;
using Application.Features.Trainings.Queries.GetAll;
using Application.Features.Trainings.Queries.GetById;
using Application.Features.Trainings.Queries.GetList;
using Application.Features.WorkflowAction.Queries.GetAvailable;
using Asp.Versioning;
using AutoMapper;
using Azure.Core;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NidecHLMS.API.Controllers.Base;
using NidecHLMS.API.DTOs.Enrollments;
using NidecHLMS.API.DTOs.Trainings.Request;

namespace NidecHLMS.API.Controllers.v1
{
	[ApiController]
	[ApiVersion(1.0)]
	[Route("api/v{version:apiVersion}/[controller]")]
	public class EnrollmentController : ApiControllerBase
	{
		private readonly ISender _sender;
		private readonly IMapper _mapper;

		public EnrollmentController(IHttpContextAccessor contextAccessor, ISender sender, IMapper mapper)
			: base(contextAccessor)
		{
			_sender = sender;
			_mapper = mapper;
		}

		[HttpPost("Create")]
		//[Authorize]
		public async Task<IActionResult> Submit(SubmitUserTrainingEnrollmentFormRequest request ,CancellationToken ct)
		{
			var command = _mapper.Map<SubmitEnrollmentCommand>(source: request);
			var respone = await _sender.Send(command);
			return OkResponse(respone);
		}

		[HttpPost("{id}/{actionId}/Execute")]
		public async Task<IActionResult> Execute(int id,int actionId ,CancellationToken ct)
		{
			var command = new ExecuteEnrollmentActionCommand
			{
				EnrollmentId = id,
				ActionCode = actionId,
			};
			var respone = await _sender.Send(command);
			return OkResponse(respone);
		}

		[HttpGet("{id}/WorkFlowActionAvailibles")]
		public async Task<IActionResult> GetAction(int id)
		{
			var query = new GetAvailableActionsQuery
			{
				EnrollmentId = id,
			};
			var respone = await _sender.Send(query);
			return OkResponse(respone);
		}
	}
}
