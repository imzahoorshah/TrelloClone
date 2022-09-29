using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trello.Core.Entities
{
    public class Card
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public Int64 CardId { get; set; }
        public Int64 ColumnId { get; set; }
        public Int64 UserId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public User User { get; set; } = new User();
        public DateTime? DueDate { get; set; }
        public bool? IsArchived { get; set; }
        public bool? IsComplete { get; set; }
        public bool? IsSubscribed { get; set; }
        public DateTime? LastActivity { get; set; }
        public DateTime? CreationDate { get; set; }
        public List<Label> Tags { get; set; } = new List<Label>();
    }
}
