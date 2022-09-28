using Trello.Core.Repositories;
using Trello.Infrastructure.Data;
using Trello.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trello.Infrastructure.Repositories
{
    public class EmployeeRepository : Repository<Trello.Core.Entities.Employee>, IEmployeeRepository
    {
        public EmployeeRepository(EmployeeContext employeeContext) : base(employeeContext)
        {

        }
        public async Task<IEnumerable<Core.Entities.Employee>> GetEmployeeByLastName(string lastname)
        {
            return await _employeeContext.Employees
                .Where(m => m.LastName == lastname)
                .ToListAsync();
        }
    }
}
