using Application.Common.Paging;
using Application.Features.Trainings.Commands.Create;
using Application.Features.Trainings.Queries.GetList;
using Asp.Versioning;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NidecHLMS.API.Controllers.Base;
using NidecHLMS.API.DTOs.Trainings.Create;
using NidecHLMS.API.DTOs.Trainings.GetList;

namespace NidecHLMS.API.Controllers.v1
{
    [ApiController]
    [ApiVersion(1.0)]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class TrainingController : ApiControllerBase
    {
        private readonly ISender _sender;
        private readonly IMapper _mapper;

        public TrainingController(IHttpContextAccessor contextAccessor, ISender sender, IMapper mapper)
            : base(contextAccessor)
        {
            _sender = sender;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateTrainingRequest request)
        {
            var command = _mapper.Map<CreateTrainingCommand>(request);
            var result = await _sender.Send(command);
            return Ok(CreateResponse(result, "Training created successfully."));
        }

        [HttpGet("GetAllTrainingContent")]
        public async Task<IActionResult> GetAllTraining([FromQuery] GetTrainingContentRequest request)
        {
            var query = _mapper.Map<GetTrainingListQuery>(request);
            var result = await _sender.Send(query);

            var response = new PagedResult<TrainingContentListItemResponse>
            {
                Items = _mapper.Map<List<TrainingContentListItemResponse>>(result.Items),
                PageIndex = result.PageIndex,
                PageSize = result.PageSize,
                TotalCount = result.TotalCount
            };

            return Ok(CreateResponse(response, "Training content retrieved successfully."));
        }
    }
}
