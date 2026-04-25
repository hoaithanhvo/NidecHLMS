using Application.Common.Paging;
using Application.DTOs.Responses.Trainings;
using Application.Features.Trainings.Commands.Create;
using Application.Features.Trainings.Commands.Delete;
using Application.Features.Trainings.Commands.Update;
using Application.Features.Trainings.Queries.GetAll;
using Application.Features.Trainings.Queries.GetById;
using Application.Features.Trainings.Queries.GetList;
using Application.Interfaces.Common;
using Asp.Versioning;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NidecHLMS.API.Controllers.Base;
using NidecHLMS.API.DTOs.Trainings.Request;

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
        public async Task<IActionResult> Create(CreateTrainingFormRequest request, CancellationToken ct)
        {
            var command = _mapper.Map<CreateTrainingCommand>(request);

            var result = await _sender.Send(command);

            return Created(string.Empty, CreateResponse(result, "Training created successfully.", StatusCodes.Status201Created));
        }

        [HttpPut("Update/{id:int}")]
        public async Task<IActionResult> Update(int id, UpdateTrainingFormRequest request)
        {
            var command = _mapper.Map<UpdateTrainingCommand>(request);
            command.Id = id;

            var result = await _sender.Send(command);
            return OkResponse(result, "Training created successfully.");
        }

        [HttpGet("GetTrainingContentByKeyWord")]
        public async Task<IActionResult> GetAllTraining([FromQuery] GetTrainingContentFormRequest request,CancellationToken ct)
        {
            var query = _mapper.Map<GetTrainingListQuery>(request);

            var result = await _sender.Send(query);
            return OkResponse(result, "Training content retrieved successfully.");
        }

        [HttpGet("GetAllTrainingContent")]
        public async Task<IActionResult> GetAll([FromQuery] GetAllTrainingContentFormRequest request, CancellationToken ct)
        {
            var query = _mapper.Map<GetAllTrainingQuery>(request);

            var result = await _sender.Send(query);
            return OkResponse(result, "All training content retrieved successfully.");
        }

        [HttpGet("GetById/{id:int}")]
        public async Task<IActionResult> GetTrainingContentById(int id, CancellationToken ct)
        {
            var query = new GetTrainingByIdQuery { Id = id };

            var result = await _sender.Send(query);

            return OkResponse(result, "Training content detail retrieved successfully.");
        }

        [HttpPatch("Delete/{id:int}")]
        public async Task<IActionResult> SoftDelete(int id)
        {
            var command = new DeleteTrainingCommand { Id = id };

            var result = await _sender.Send(command);

            return OkResponse(result, "Training deleted (soft) successfully.");
        }

        [Authorize]
        [HttpGet("debug-auth")]
        public IActionResult Debug()
        {
            return Ok(new
            {
                isAuth = User.Identity?.IsAuthenticated,
                claims = User.Claims.Select(x => new { x.Type, x.Value })
            });
        }
    }
}
