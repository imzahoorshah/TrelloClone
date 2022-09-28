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
using Trello.Core.Entities;

namespace Trello.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColumnController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ColumnController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<List<Column>> Get()
        {
            return await _mediator.Send(new GetAllColumnQuery());
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<ColumnResponse>> CreateColumn([FromBody] CreateColumnCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
