using Application.Features.Enrollments.Commands.ApproveEnrollment;
using Application.Features.Enrollments.Commands.RegisterEnrollment;
using Application.Features.Trainings.Commands.Create;
using Application.Features.Trainings.Queries.GetAll;
using Application.Features.Trainings.Queries.GetById;
using Application.Features.Trainings.Queries.GetList;
using Asp.Versioning;
using AutoMapper;
using Azure.Core;
using MediatR;
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

		// đăng ký
		[HttpPost]
		public async Task<IActionResult> Register(RegisterUserTrainingEnrollmentFormRequest request)
		{
			var command = _mapper.Map<RegisterEnrollmentCommand>(source: request);
			var id = await _sender.Send(command);
			return Ok(new { id });
		}

		// admin duyệt
		[HttpPost("{id}/approve")]
		public async Task<IActionResult> Approve(int id)
		{
			await _sender.Send(new ApproveEnrollmentCommand { Id = id });
			return Ok();
		}

		//// reject
		//[HttpPost("{id}/reject")]
		//public async Task<IActionResult> Reject(int id)
		//{
		//	await _sender.Send(new RejectEnrollmentCommand { Id = id });
		//	return Ok();
		//}

		//// start learning
		//[HttpPost("{id}/start")]
		//public async Task<IActionResult> Start(int id)
		//{
		//	await _sender.Send(new StartEnrollmentCommand { Id = id });
		//	return Ok();
		//}

		//// complete
		//[HttpPost("{id}/complete")]
		//public async Task<IActionResult> Complete(int id)
		//{
		//	await _sender.Send(new CompleteEnrollmentCommand { Id = id });
		//	return Ok();
		//}
	}
}
