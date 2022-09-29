using Trello.Core.Repositories.Base;
using Trello.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trello.Infrastructure.Repositories.Base
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly TrelloContext _trelloContext;

        public Repository(TrelloContext trelloContext)
        {
            _trelloContext = trelloContext;
        }
        public async Task<T> AddAsync(T entity)
        {
            await _trelloContext.Set<T>().AddAsync(entity);
            await _trelloContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            _trelloContext.Set<T>().Remove(entity);
            await _trelloContext.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _trelloContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(Int64 id)
        {
            return await _trelloContext.Set<T>().FindAsync(id);
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
