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
    public class SearchCardByCloumnHandler : IRequestHandler<GetCardsByColumnQuery, List<Trello.Core.Entities.Card>>
    {
        private readonly ICardRepository _cardRepo;
        private readonly ILabelRepository _labelRepo;
        private readonly IUserRepository _userRepo;

        public SearchCardByCloumnHandler(ICardRepository cardRepository, ILabelRepository labelRepository, IUserRepository userRepository)
        {
            _cardRepo = cardRepository;
            _labelRepo = labelRepository;
            _userRepo = userRepository;
        }
        public async Task<List<Core.Entities.Card>> Handle(GetCardsByColumnQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var cards = (List<Card>)await Task.Run(() => _cardRepo.GetCardByColumnId(request.ColumnId));
                if (cards != null)
                {
                    foreach (var card in cards)
                    {
                        var labels = (List<Label>)await _labelRepo.GetLabelByCardId(card.CardId);
                        card.User = (User)await _userRepo.GetUserById(card.UserId);
                    }
                }
                return cards;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
