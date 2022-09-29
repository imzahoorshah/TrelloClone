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
   public class CreateUserHandler : IRequestHandler<CreateUserCommand, UserResponse>
    {
        private readonly IUserRepository _userRepo;

        public CreateUserHandler(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        } 

        public async Task<UserResponse> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var userEntitiy = LabelMapper.Mapper.Map<Trello.Core.Entities.User>(request);
            if (userEntitiy is null)
            {
                throw new ApplicationException("Issue with mapper");
            }
            var userBoard = await _userRepo.AddAsync(userEntitiy);
            var userResponse = UserMapper.Mapper.Map<UserResponse>(userBoard);
            return userResponse;
        }
    }
}
