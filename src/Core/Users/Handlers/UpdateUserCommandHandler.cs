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
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, int>
    {
        private readonly IUserRepository _userRepository;

        public UpdateUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<int> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            User user = new()
            {
                DateOfBirth = request.UserDto.DateOfBirth,
                Address = new Address() { Area = request.UserDto.Area, City = request.UserDto.City, State = request.UserDto.State },
                Gender = request.UserDto.Gender,
                LastModifiedBy = "Venugopal",
                LastModifiedOn = DateTime.UtcNow
            };

            var result = await _userRepository.Update(request.Id, user);
            return result;
        }
    }
}
