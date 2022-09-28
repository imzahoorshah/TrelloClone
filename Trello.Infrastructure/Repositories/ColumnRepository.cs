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
    public class LabelRepository : Repository<Trello.Core.Entities.Label>, ILabelRepository
    {
        public LabelRepository(TrelloContext trelloContext) : base(trelloContext)
        {

        }

        async Task<IEnumerable<Label>> ILabelRepository.GetEmployeeByLastName(string lastname)
        {
            return await _trelloContext.Label
                 .Where(m => m.Name == lastname)
                 .ToListAsync();
        }
    }
}
