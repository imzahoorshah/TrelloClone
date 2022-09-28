using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trello.Core.Repositories.Base;

namespace Trello.Core.Repositories
{

    public interface ILabelRepository : IRepository<Trello.Core.Entities.Label>
    {
        //custom operations here
        Task<IEnumerable<Trello.Core.Entities.Label>> GetEmployeeByLastName(string lastname);
    }
}
