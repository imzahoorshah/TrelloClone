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
    public class CardMappingProfile : Profile
    {
        public CardMappingProfile()
        {
            CreateMap<Trello.Core.Entities.Employee, CardResponse>().ReverseMap();
            CreateMap<Trello.Core.Entities.Employee, CreateCardCommand>().ReverseMap();
        }
    }
}
