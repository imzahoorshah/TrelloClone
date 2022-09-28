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
   public class CreateLabelHandler : IRequestHandler<CreateLabelCommand, LabelResponse>
    {
        private readonly ILabelRepository _labelRepo;

        public CreateLabelHandler(ILabelRepository labelRepo)
        {
            _labelRepo = labelRepo;
        }
        public async Task<LabelResponse> Handle(CreateLabelCommand request, CancellationToken cancellationToken)
        {
            var labelEntitiy = LabelMapper.Mapper.Map<Trello.Core.Entities.Label>(request);
            if (labelEntitiy is null)
            {
                throw new ApplicationException("Issue with mapper");
            }
            var newLabel = await _labelRepo.AddAsync(labelEntitiy);
            var labelResponse = CardMapper.Mapper.Map<LabelResponse>(newLabel);
            return labelResponse;
        } 
        
    }
}
