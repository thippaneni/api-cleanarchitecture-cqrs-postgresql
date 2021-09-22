using MediatR;
using Rusv.UserManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rusv.UserManagement.Core.Users.Queries
{
    public class GetUserByIdQuery : IRequest<User>
    {
        public Guid Id { get; }

        public GetUserByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}
