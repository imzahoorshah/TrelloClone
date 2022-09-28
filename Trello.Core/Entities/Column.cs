using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trello.Core.Entities
{
    public class Column
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public string Name { get; set; }
        public string Description { get; set; }
        public List<Card> Cards { get; set; }
        public DateTime? Creation { get; set; }
    }
}
