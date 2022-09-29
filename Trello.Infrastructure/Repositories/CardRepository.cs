using Trello.Core.Repositories;
using Trello.Infrastructure.Data;
using Trello.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trello.Core.Entities;

namespace Trello.Infrastructure.Repositories
{
    public class CardRepository : Repository<Card>, ICardRepository
    {
        public CardRepository(TrelloContext trelloContext) : base(trelloContext)
        {

        }

        async Task<IEnumerable<Card>> ICardRepository.GetCardByColumnId(long ColumnId)
        {
            return await _trelloContext.Cards
                .Where(m => m.ColumnId == ColumnId)
                .ToListAsync();
        }

        async Task<Card> ICardRepository.GetCardById(long Id)
        {
            throw new NotImplementedException();
        }

        async Task<IEnumerable<Card>> ICardRepository.GetCardByUserId(long UserId)
        {
            throw new NotImplementedException();
        }

        
    }
}
