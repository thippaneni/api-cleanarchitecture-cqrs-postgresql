using Rusv.UserManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rusv.UserManagement.Core.Users.Repository
{
    public interface IUserRepository
    {
        Task<User> GetById(Guid id);
        Task<IEnumerable<User>> GetAll();
        Task<int> Add(User user);
        Task<int> Delete(Guid id);
        Task<int> Update(Guid Id, User user);
    }
}
