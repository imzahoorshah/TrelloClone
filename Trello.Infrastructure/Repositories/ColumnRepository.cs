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
    public class ColumnRepository : Repository<Trello.Core.Entities.Column>, IColumnRepository
    {
        public ColumnRepository(TrelloContext trelloContext) : base(trelloContext)
        {

        }

        async Task<IEnumerable<Column>> IColumnRepository.GetColumnById(Int64 Id)
        {
            return await _trelloContext.Column
                 .Where(m => m.ColumnId == Id)
                 .ToListAsync();
        }

        async Task<IEnumerable<Column>> IColumnRepository.GetColumnByBoardId(Int64 boardId)
        {
            return await _trelloContext.Column
                 .Where(m => m.BoardId == boardId)
                 .ToListAsync();
        }
    }
}
