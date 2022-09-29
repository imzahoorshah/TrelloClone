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
    public class BoardRepository : Repository<Trello.Core.Entities.Board>, IBoardRepository
    {
        public BoardRepository(TrelloContext trelloContext) : base(trelloContext)
        {

        }

        async Task<IEnumerable<Board>> IBoardRepository.GetBoardById(Int64 Id)
        {
            return await _trelloContext.Board
                 .Where(m => m.BoardId == Id)
                 .ToListAsync();
        }
    }
}
