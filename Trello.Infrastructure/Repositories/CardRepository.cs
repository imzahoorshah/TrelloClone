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
    public class CardRepository : Repository<Trello.Core.Entities.Card>, ICardRepository
    {
        public CardRepository(TrelloContext employeeContext) : base(employeeContext)
        {

        }

        async Task<IEnumerable<Card>> ICardRepository.GetEmployeeByLastName(string lastname)
        {
            return await _employeeContext.Cards
                 .Where(m => m.Name == lastname)
                 .ToListAsync();
        }
    }
}
