using Trello.Application.Queries;
using Trello.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Trello.Application.Handlers.QueryHandlers
{
    public class GetAllCardHandler : IRequestHandler<GetAllCardQuery, List<Trello.Core.Entities.Card>>
    {
        private readonly ICardRepository _cardRepo;

        public GetAllCardHandler(ICardRepository cardRepository)
        {
            _cardRepo = cardRepository;
        }
        public async Task<List<Core.Entities.Card>> Handle(GetAllCardQuery request, CancellationToken cancellationToken)
        {
            return (List<Core.Entities.Card>)await _cardRepo.GetAllAsync();
        }
    }
}
