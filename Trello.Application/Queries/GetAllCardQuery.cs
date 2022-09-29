using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trello.Application.Queries
{
    public class GetAllCardQuery : IRequest<List<Trello.Core.Entities.Card>>
    {

    } 
    public class GetCardsByColumnQuery : IRequest<List<Trello.Core.Entities.Card>>
    {
        public Int64 ColumnId { get; set; }
    }
}
