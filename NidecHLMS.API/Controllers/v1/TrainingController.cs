using Application.Common.Paging;
using Application.Features.Trainings.Commands.Create;
using Application.Features.Trainings.Queries.GetList;
using Asp.Versioning;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NidecHLMS.API.DTOs.Trainings.Create;
using NidecHLMS.API.DTOs.Trainings.GetList;
using NidecHLMS.API.DTOs.Trainings.Requests;
using System.Net.WebSockets;

namespace NidecHLMS.API.Controllers.v1
{
	[ApiController]
	[ApiVersion(1.0)]
	[Route("api/v{version:apiVersion}/[controller]")]
	public class TrainingController : ControllerBase
	{
		private readonly ISender _sender;
		private readonly IMapper _mapper;

		public TrainingController(IHttpContextAccessor contextAccessor, ISender sender,IMapper mapper)
		{
			_sender = sender;
			_mapper = mapper;
		}

		// CREATE
		[HttpPost]
		public async Task<IActionResult> Create(CreateTrainingRequest request)
		{
			var command = _mapper.Map<CreateTrainingCommand>(request);
			
			var result = await _sender.Send(command);
			return Ok(result);
		}

		[HttpGet("GetAllTrainingContent")]
		public async Task<IActionResult> GetAllTraining(
	[FromQuery] GetTrainingContentRequest request)
		{
			// map API → Application
			var query = _mapper.Map<GetTrainingListQuery>(request);

			var result = await _sender.Send(query);

			// map Application → API response
			var response = new PagedResult<TrainingContentListItemResponse>
			{
				Items = _mapper.Map<List<TrainingContentListItemResponse>>(result.Items),
				PageIndex = result.PageIndex,
				PageSize = result.PageSize,
				TotalCount = result.TotalCount
			};

			return Ok(response);
		}
	}
}
