using Trello.Application.Commands;
using Trello.Application.Mapper;
using Trello.Application.Responses;
using Trello.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Trello.Application.Handlers.CommandHandlers
{

    public class CreateCardHandler : IRequestHandler<CreateCardCommand, CardResponse>
    {
        private readonly ICardRepository _cardRepo;

        public CreateCardHandler(ICardRepository cardRepository)
        {
            _cardRepo = cardRepository;
        }
        public async Task<CardResponse> Handle(CreateCardCommand request, CancellationToken cancellationToken)
        {
            var cardEntitiy = CardMapper.Mapper.Map<Trello.Core.Entities.Card>(request);
            if(cardEntitiy is null)
            {
                throw new ApplicationException("Issue with mapper");
            } 
            var newCard = await _cardRepo.AddAsync(cardEntitiy);
            var cardResponse = CardMapper.Mapper.Map<CardResponse>(newCard);
            return cardResponse;
        }
    }
}
