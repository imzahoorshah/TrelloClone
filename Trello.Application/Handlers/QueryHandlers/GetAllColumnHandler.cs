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
    public class GetAllColumnHandler : IRequestHandler<GetAllColumnQuery, List<Trello.Core.Entities.Column>>
    {
        private readonly IColumnRepository _colRepo;

        public GetAllColumnHandler(IColumnRepository colRepository)
        {
            _colRepo = colRepository;
        } 

        public async Task<List<Column>> Handle(GetAllColumnQuery request, CancellationToken cancellationToken)
        {
            return (List<Core.Entities.Column>)await _colRepo.GetAllAsync();
        }
    }
}
