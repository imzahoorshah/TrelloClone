using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trello.Core.Repositories.Base;

namespace Trello.Core.Repositories
{

    public interface IBoardRepository : IRepository<Trello.Core.Entities.Board>
    {
        //custom operations here
        Task<IEnumerable<Trello.Core.Entities.Board>> GetBoardById(Int64 Id);
    }
}
