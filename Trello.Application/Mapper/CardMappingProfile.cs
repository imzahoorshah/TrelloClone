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
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Trello.Core.Entities.Card, CardResponse>().ReverseMap();
            CreateMap<Trello.Core.Entities.Card, CreateCardCommand>().ReverseMap();


            CreateMap<Trello.Core.Entities.Label, LabelResponse>().ReverseMap();
            CreateMap<Trello.Core.Entities.Label, CreateLabelCommand>().ReverseMap();

            CreateMap<Trello.Core.Entities.Board, BoardResponse>().ReverseMap();
            CreateMap<Trello.Core.Entities.Board, CreateBoardCommand>().ReverseMap();

            CreateMap<Trello.Core.Entities.Column, ColumnResponse>().ReverseMap();
            CreateMap<Trello.Core.Entities.Column, CreateColumnCommand>().ReverseMap();
        }
    }
}
