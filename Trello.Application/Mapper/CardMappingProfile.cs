using AutoMapper;
using Trello.Application.Commands;
using Trello.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trello.Core.Entities;

namespace Trello.Application.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Card, CardResponse>().ReverseMap();
            CreateMap<Card, CreateCardCommand>().ReverseMap();


            CreateMap<Label, LabelResponse>().ReverseMap();
            CreateMap<Label, CreateLabelCommand>().ReverseMap();

            CreateMap<Board, BoardResponse>().ReverseMap();
            CreateMap<Board, CreateBoardCommand>().ReverseMap();

            CreateMap<Column, ColumnResponse>().ReverseMap();
            CreateMap<Column, CreateColumnCommand>().ReverseMap();

            CreateMap<User, UserResponse>().ReverseMap();
            CreateMap<User, CreateUserCommand>().ReverseMap();
        }
    }
}
