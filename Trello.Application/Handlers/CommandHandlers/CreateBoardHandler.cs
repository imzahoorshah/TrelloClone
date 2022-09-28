using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Trello.Application.Commands;
using Trello.Application.Mapper;
using Trello.Application.Responses;
using Trello.Core.Repositories;

namespace Trello.Application.Handlers.CommandHandlers
{
   public class CreateBoardHandler : IRequestHandler<CreateBoardCommand, BoardResponse>
    {
        private readonly IBoardRepository _boardRepo;

        public CreateBoardHandler(IBoardRepository boardRepo)
        {
            _boardRepo = boardRepo;
        } 

        public async Task<BoardResponse> Handle(CreateBoardCommand request, CancellationToken cancellationToken)
        {
            var boardEntitiy = LabelMapper.Mapper.Map<Trello.Core.Entities.Board>(request);
            if (boardEntitiy is null)
            {
                throw new ApplicationException("Issue with mapper");
            }
            var newBoard = await _boardRepo.AddAsync(boardEntitiy);
            var boardResponse = BoardMapper.Mapper.Map<BoardResponse>(newBoard);
            return boardResponse;
        }
    }
}
