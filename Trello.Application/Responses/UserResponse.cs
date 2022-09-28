using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trello.Core.Entities;

namespace Trello.Application.Responses
{
    public class UserResponse
    {
		public Int64 UserId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string DisplayName { get; set; }
		public bool? IsBusinessClass { get; set; }
		public string Url { get; set; }
		public DateTime? CreationDate { get; set; }
	}
}
