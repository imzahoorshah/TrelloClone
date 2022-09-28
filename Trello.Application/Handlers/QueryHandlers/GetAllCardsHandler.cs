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
    public class GetAllCardsHandler : IRequestHandler<GetAllCardsQuery, List<Trello.Core.Entities.Card>>
    {
        private readonly ICardRepository _cardRepo;

        public GetAllCardsHandler(ICardRepository cardRepository)
        {
            _cardRepo = cardRepository;
        }
        public async Task<List<Core.Entities.Card>> Handle(GetAllCardsQuery request, CancellationToken cancellationToken)
        {
            return (List<Core.Entities.Card>)await _cardRepo.GetAllAsync();
        }
    }
}
