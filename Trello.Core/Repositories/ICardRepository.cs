using Trello.Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trello.Core.Entities;

namespace Trello.Core.Repositories
{
    public interface ICardRepository : IRepository<Trello.Core.Entities.Card>
    {
        //custom operations here
        Task<Card> GetCardById(Int64 Id);
        Task<IEnumerable<Card>> GetCardByColumnId(Int64 ColumnId);
        Task<IEnumerable<Card>> GetCardByTag(Int64 LabelId);
        Task<IEnumerable<Card>> GetCardByTime(DateTime CreatedOn);
        Task<IEnumerable<Card>> GetCardByUserId(Int64 UserId);
    }
}
