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
            CreateMap<Trello.Core.Entities.Employee, EmployeeResponse>().ReverseMap();
            CreateMap<Trello.Core.Entities.Employee, CreateEmployeeCommand>().ReverseMap();
        }
    }
}
