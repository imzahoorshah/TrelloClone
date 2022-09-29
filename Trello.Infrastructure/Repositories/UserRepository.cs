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
    public class UserRepository : Repository<Trello.Core.Entities.User>, IUserRepository
    {
        public UserRepository(TrelloContext trelloContext) : base(trelloContext)
        {

        } 
        async Task<User> IUserRepository.GetUserById(Int64 Id)
        {
            return await _trelloContext.User
                 .Where(m => m.UserId == Id).FirstOrDefaultAsync();
        }  
    }
}
