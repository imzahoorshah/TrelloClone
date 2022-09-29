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
    public class CreateCardCommand : IRequest<CardResponse> 
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public User User { get; set; }
        public DateTime? DueDate { get; set; }
        public bool? IsArchived { get; set; }
        public bool? IsComplete { get; set; }
        public bool? IsSubscribed { get; set; }
        public DateTime? LastActivity { get; set; }
        public DateTime? CreationDate { get; set; }
        public List<Label> Tags { get; set; }
    }
}
