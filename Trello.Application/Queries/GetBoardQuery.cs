using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trello.Core.Entities;

namespace Trello.Application.Queries
{
    public class GetBoardQuery : IRequest<Board>
    {
        public Int64 BoardId { get; init; } 
    }
}
