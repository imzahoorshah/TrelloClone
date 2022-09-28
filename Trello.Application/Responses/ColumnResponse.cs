using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trello.Core.Entities;

namespace Trello.Application.Responses
{
    public class ColumnResponse
    {
        public Int64 ColumnId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Card> Cards { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
