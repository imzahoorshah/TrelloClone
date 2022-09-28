using Trello.Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trello.Core.Repositories
{
    public interface ICardRepository : IRepository<Trello.Core.Entities.Card>
    {
        //custom operations here
        Task<IEnumerable<Trello.Core.Entities.Card>> GetEmployeeByLastName(string lastname);
    }
}
