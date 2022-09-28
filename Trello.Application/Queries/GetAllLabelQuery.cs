using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trello.Application.Queries
{
    public class GetAllLabelQuery : IRequest<List<Trello.Core.Entities.Label>>
    {

    }
}
