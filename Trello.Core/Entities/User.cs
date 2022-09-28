using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trello.Core.Entities
{
  public  class User
    {
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]

		public string Name { get; set; }
		public string Description { get; set; }
		public string DisplayName { get; set; }
		public bool? IsBusinessClass { get; set; }
		public string Url { get; set; }
		public DateTime? CreationDate { get; set; }
	}
}
