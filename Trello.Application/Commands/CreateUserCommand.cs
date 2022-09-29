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
    public class CreateUserCommand : IRequest<UserResponse> 
    { 
		public string Name { get; set; }
		public string Description { get; set; }
		public string DisplayName { get; set; }
		public bool? IsBusinessClass { get; set; }
		public string Url { get; set; }
		public DateTime? CreationDate { get; set; }
	}
}
