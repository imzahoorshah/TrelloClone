using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trello.Application.Queries
{
    public class GetAllCardsQuery : IRequest<List<Trello.Core.Entities.Card>>
    {

    }
}
