using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trello.Infrastructure.Data
{
    public class TrelloContext : DbContext
    {
        public TrelloContext(DbContextOptions<TrelloContext> options) : base (options)
        {

        }

        public DbSet<Trello.Core.Entities.Board> Board { get; set; }
        public DbSet<Trello.Core.Entities.Card> Cards { get; set; }
        public DbSet<Trello.Core.Entities.Column> Column { get; set; }
        public DbSet<Trello.Core.Entities.Label> Label { get; set; }
        public DbSet<Trello.Core.Entities.User> User { get; set; }
    }
}
