using Trello.Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trello.Core.Repositories
{
    public interface IEmployeeRepository : IRepository<Trello.Core.Entities.Employee>
    {
        //custom operations here
        Task<IEnumerable<Trello.Core.Entities.Employee>> GetEmployeeByLastName(string lastname);
    }
}
