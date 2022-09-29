using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trello.Core.Entities;
using Trello.Core.Repositories.Base;

namespace Trello.Core.Repositories
{

    public interface IUserRepository : IRepository<Trello.Core.Entities.User>
    {
        //custom operations here
        Task<User> GetUserById(Int64 Id);
    }
}
