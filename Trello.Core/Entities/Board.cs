using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trello.Core.Entities
{
   public  class Board
    {
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]

		public string Name { get; set; }
		public string Description { get; set; }
		public bool? IsClosed { get; set; }
		public bool? IsPinned { get; set; }
		public bool? IsStarred { get; set; }
		public bool? IsSubscribed { get; set; }	 
		public List<Column> Columns { get; set; }
		public string Url { get; set; }
		public DateTime? LastActivity { get; set; }
		public DateTime? LastViewed { get; set; }
		public DateTime? Creation { get; set; } 
	}
}
