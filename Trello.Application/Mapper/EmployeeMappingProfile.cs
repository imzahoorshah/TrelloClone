using AutoMapper;
using Trello.Application.Commands;
using Trello.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trello.Application.Mapper
{
    public class EmployeeMappingProfile : Profile
    {
        public EmployeeMappingProfile()
        {
            CreateMap<Employee.Core.Entities.Employee, EmployeeResponse>().ReverseMap();
            CreateMap<Employee.Core.Entities.Employee, CreateEmployeeCommand>().ReverseMap();
        }
    }
}
