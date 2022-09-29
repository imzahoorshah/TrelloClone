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
    public class GetBoardHandler : IRequestHandler<GetBoardQuery, Board>
    {
        private readonly IBoardRepository _boardRepo;
        private readonly IColumnRepository _colRepo;
        private readonly ICardRepository _cardRepo;
        private readonly ILabelRepository _labelRepo;
        private readonly IUserRepository _userRepo;


        public GetBoardHandler(IBoardRepository boardRepository, IColumnRepository colRepository,
            ICardRepository cardRepository, ILabelRepository labelRepository, IUserRepository userRepository)
        {
            _boardRepo = boardRepository;
            _colRepo = colRepository;
            _cardRepo = cardRepository;
            _labelRepo = labelRepository;
            _userRepo = userRepository;
        }

        public async Task<Board> Handle(GetBoardQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var board = await Task.Run(() => _boardRepo.GetByIdAsync(request.BoardId));
                if (board != null)
                {
                    var cols = (List<Column>)await _colRepo.GetColumnByBoardId(board.BoardId);
                    if (cols != null)
                    {
                        foreach (var col in cols)
                        {
                            var cards = (List<Card>)await _cardRepo.GetCardByColumnId(col.ColumnId);
                            if (cards != null)
                            {
                                foreach (var card in cards)
                                {
                                    var labels = (List<Label>)await _labelRepo.GetLabelByCardId(card.CardId);
                                    card.User = (User)await _userRepo.GetUserById(card.UserId);
                                }
                            }
                        }
                        board.Columns.AddRange(cols);
                    }
                }
                return board;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
