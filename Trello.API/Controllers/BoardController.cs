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
    public class BoardController : ControllerBase
    {
        private readonly IMediator _mediator;
        public BoardController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<Board> Get([FromQuery] GetBoardQuery query)
        {
            return await _mediator.Send(query);
        }
 


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<BoardResponse>> CreateBoard([FromBody] CreateBoardCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
