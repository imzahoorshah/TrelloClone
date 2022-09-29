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
    public class CardController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CardController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<List<Trello.Core.Entities.Card>> Get()
        {
            return await _mediator.Send(new GetAllCardQuery());
        }

        [Route("[action]")]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<List<Trello.Core.Entities.Card>> SearchCardByCloumn([FromQuery] GetCardsByColumnQuery query)
        {
            return await _mediator.Send(query);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<CardResponse>> CreateCard([FromBody] CreateCardCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
