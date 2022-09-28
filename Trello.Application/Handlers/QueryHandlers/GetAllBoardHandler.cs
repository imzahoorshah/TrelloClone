using Trello.Application.Queries;
using Trello.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Trello.Core.Entities;

namespace Trello.Application.Handlers.QueryHandlers
{
    public class GetAllBoardHandler : IRequestHandler<GetAllBoardQuery, List<Trello.Core.Entities.Board>>
    {
        private readonly IBoardRepository _boardRepo;

        public GetAllBoardHandler(IBoardRepository boardRepository)
        {
            _boardRepo = boardRepository;
        }
        
        public async Task<List<Board>> Handle(GetAllBoardQuery request, CancellationToken cancellationToken)
        {
            return (List<Core.Entities.Board>)await _boardRepo.GetAllAsync();
        }
    }
}
