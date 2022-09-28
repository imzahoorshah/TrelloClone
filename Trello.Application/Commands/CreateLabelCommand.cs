using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trello.Application.Responses;

namespace Trello.Application.Commands
{
    public class CreateLabelCommand : IRequest<LabelResponse>
    {
    }
}
