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

    public class GetCardsByTagQuery : IRequest<List<Trello.Core.Entities.Card>>
    {
        public Int64 Label { get; set; }
    }

    public class GetCardsByTimeQuery : IRequest<List<Trello.Core.Entities.Card>>
    {
        public DateTime CreatedOn { get; set; }
    }

    public class GetCardsByUserQuery : IRequest<List<Trello.Core.Entities.Card>>
    {
        public Int64 UserId { get; set; }
    }
}
