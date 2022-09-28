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

    public class CreateEmployeeHandler : IRequestHandler<CreateEmployeeCommand, EmployeeResponse>
    {
        private readonly IEmployeeRepository _employeeRepo;

        public CreateEmployeeHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepo = employeeRepository;
        }
        public async Task<EmployeeResponse> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employeeEntitiy = EmployeeMapper.Mapper.Map<Trello.Core.Entities.Employee>(request);
            if(employeeEntitiy is null)
            {
                throw new ApplicationException("Issue with mapper");
            }
            var newEmployee = await _employeeRepo.AddAsync(employeeEntitiy);
            var employeeResponse = EmployeeMapper.Mapper.Map<EmployeeResponse>(newEmployee);
            return employeeResponse;
        }
    }
}
