using Trello.Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trello.Core.Repositories
{
    public interface IUserRepository : IRepository<Trello.Core.Entities.User>
    {
        //custom operations here
        Task<IEnumerable<Trello.Core.Entities.User>> GetEmployeeByLastName(string lastname);
    }
}
