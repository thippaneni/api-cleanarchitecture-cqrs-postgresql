using FluentValidation;
using Rusv.UserManagement.Core.Users.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rusv.UserManagement.Core.Users.Validations
{
    public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
    {
        public CreateUserCommandValidator()
        {
            RuleFor(e=> e.UserDto.Area)
                .NotEmpty()
                .NotNull();
        }
    }
}
