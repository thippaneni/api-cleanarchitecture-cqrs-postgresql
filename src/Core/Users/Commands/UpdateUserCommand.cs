using MediatR;
using Rusv.UserManagement.Core.Users.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rusv.UserManagement.Core.Users.Commands
{
    public class UpdateUserCommand : IRequest<int>
    {
        public UpdateUserDto UserDto { get; }
        public Guid Id { get; }

        public UpdateUserCommand(Guid id, UpdateUserDto userDto)
        {
            UserDto = userDto;
            Id = id;
        }
    }
}
