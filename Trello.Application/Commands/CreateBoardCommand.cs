using Trello.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trello.Core.Entities;

namespace Trello.Application.Commands
{
    public class CreateBoardCommand : IRequest<BoardResponse> 
    {
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
