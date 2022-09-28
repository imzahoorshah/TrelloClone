using Trello.Application.Commands;
using Trello.Application.Mapper;
using Trello.Application.Responses;
using Trello.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Trello.Application.Handlers.CommandHandlers
{

    public class CreateCardHandler : IRequestHandler<CreateCardCommand, CardResponse>
    {
        private readonly ICardRepository _employeeRepo;

        public CreateCardHandler(ICardRepository employeeRepository)
        {
            _employeeRepo = employeeRepository;
        }
        public async Task<CardResponse> Handle(CreateCardCommand request, CancellationToken cancellationToken)
        {
            var employeeEntitiy = CardMapper.Mapper.Map<Trello.Core.Entities.Card>(request);
            if(employeeEntitiy is null)
            {
                throw new ApplicationException("Issue with mapper");
            }
            var newEmployee = await _employeeRepo.AddAsync(employeeEntitiy);
            var employeeResponse = CardMapper.Mapper.Map<CardResponse>(newEmployee);
            return employeeResponse;
        }
    }
}
