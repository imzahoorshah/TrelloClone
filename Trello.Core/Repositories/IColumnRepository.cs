using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trello.Core.Repositories.Base;

namespace Trello.Core.Repositories
{

    public interface IColumnRepository : IRepository<Trello.Core.Entities.Column>
    {
        //custom operations here
        Task<IEnumerable<Trello.Core.Entities.Column>> GetEmployeeByLastName(string lastname);
    }
}
