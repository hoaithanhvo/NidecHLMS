using Application.Features.Trainings.Commands.Create;
using Application.Features.Trainings.Queries.GetAll;
using Application.Features.Trainings.Queries.GetById;
using Application.Features.Trainings.Queries.GetList;
using Asp.Versioning;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

        public TrainingController(IHttpContextAccessor contextAccessor, ISender sender)
            : base(contextAccessor)
        {
            _sender = sender;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateTrainingFormRequest request, CancellationToken ct)
        {
            var command = new CreateTrainingCommand
            {
                ManagementNumber = request.ManagementNumber,
                TrainingContentName = request.TrainingContentName,
                OperationId = request.OperationId,
                LifecycleId = request.LifecycleId,
                //CreatedBy = userId,
                //UpdatedBy = userId
            };

            var result = await _sender.Send(command);
            return OkResponse(result, "Training created successfully.");
        }

        [HttpGet("GetTrainingContentByKeyWord")]
        public async Task<IActionResult> GetAllTraining([FromQuery] GetTrainingContentFormRequest request,CancellationToken ct)
        {
            var query = new GetTrainingListQuery
            {
                PageIndex = request.Paging.PageIndex,
                PageSize = request.Paging.PageSize,
                Keyword = request.Keyword
            };

            var result = await _sender.Send(query);
            return OkResponse(result, "Training content retrieved successfully.");
        }

        [HttpGet("GetAllTrainingContent")]
        public async Task<IActionResult> GetAll([FromQuery] GetAllTrainingContentFormRequest request, CancellationToken ct)
        {
            var query = new GetAllTrainingQuery
            {
                PageIndex = request.Paging.PageIndex,
                PageSize = request.Paging.PageSize
            };

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
    }
}
