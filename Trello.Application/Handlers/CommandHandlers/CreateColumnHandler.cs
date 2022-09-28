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
   public class CreateColumnHandler : IRequestHandler<CreateColumnCommand, ColumnResponse>
    {
        private readonly IColumnRepository _colRepo;

        public CreateColumnHandler(IColumnRepository colRepo)
        {
            _colRepo = colRepo;
        }
        public async Task<ColumnResponse> Handle(CreateColumnCommand request, CancellationToken cancellationToken)
        {
            var colEntitiy = ColumnMapper.Mapper.Map<Trello.Core.Entities.Column>(request);
            if (colEntitiy is null)
            {
                throw new ApplicationException("Issue with mapper");
            }
            var newCol = await _colRepo.AddAsync(colEntitiy);
            var colResponse = ColumnMapper.Mapper.Map<ColumnResponse>(newCol);
            return colResponse;
        } 
        
    }
}
