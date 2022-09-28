using Trello.Application.Queries;
using Trello.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Trello.Core.Entities;

namespace Trello.Application.Handlers.QueryHandlers
{
    public class GetAllLabelHandler : IRequestHandler<GetAllLabelQuery, List<Trello.Core.Entities.Label>>
    {
        private readonly ILabelRepository _labelRepo;

        public GetAllLabelHandler(ILabelRepository labelRepository)
        {
            _labelRepo = labelRepository;
        } 

        public async Task<List<Label>> Handle(GetAllLabelQuery request, CancellationToken cancellationToken)
        {
            return (List<Core.Entities.Label>)await _labelRepo.GetAllAsync();
        }
    }
}
