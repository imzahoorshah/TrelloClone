using Trello.Application.Commands;
using Trello.Application.Queries;
using Trello.Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trello.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LabelController : ControllerBase
    {
        private readonly IMediator _mediator;
        public LabelController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<List<Trello.Core.Entities.Label>> Get()
        {
            return await _mediator.Send(new GetAllLabelQuery());
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<LabelResponse>> CreateLabel([FromBody] CreateLabelCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
