using Microsoft.EntityFrameworkCore;
using Rusv.UserManagement.Core.Common.Interfaces;
using Rusv.UserManagement.Core.Users.Repository;
using Rusv.UserManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rusv.UserManagement.Infrastructure.Users.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly IApplicationDbContext _context;
        public UserRepository(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<int> Add(User user)
        {
            _context.Users.Add(user);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(Guid id)
        {
            var userToDelete = await _context.Users.FindAsync(id);
            if (userToDelete == null)
            {
                throw new ArgumentNullException(id.ToString());
            }

            _context.Users.Remove(userToDelete);
           return await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetById(Guid id)
        {
            var user =  await _context.Users.FindAsync(id);
            return user;
        }

        public async Task<int> Update(Guid Id, User user)
        {
            var userToUpdate = await _context.Users.FindAsync(Id);
            if (userToUpdate == null)
                throw new ArgumentNullException(Id.ToString());
            userToUpdate.DateOfBirth = user.DateOfBirth;
            userToUpdate.UserName = user.UserName;
            userToUpdate.Address = user.Address;
            userToUpdate.Gender = user.Gender;
            return await _context.SaveChangesAsync();
        }
    }
}
