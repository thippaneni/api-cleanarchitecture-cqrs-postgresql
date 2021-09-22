using MediatR;
using Rusv.UserManagement.Core.Users.Commands;
using Rusv.UserManagement.Core.Users.Repository;
using Rusv.UserManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rusv.UserManagement.Core.Users.Handlers
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
    {
        private readonly IUserRepository _userRepository;

        public CreateUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            User user = new()
            {
                UserName = request.UserDto.UserName,
                DateOfBirth = request.UserDto.DateOfBirth,
                Address = new Address() { Area = request.UserDto.Area, City = request.UserDto.City, State = request.UserDto.State },
                Gender = request.UserDto.Gender,
                CreatedBy = "Venugopal"
            };

           return await _userRepository.Add(user);
        }       
    }
}
