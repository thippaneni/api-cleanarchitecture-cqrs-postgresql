using Microsoft.EntityFrameworkCore;
using Rusv.UserManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rusv.UserManagement.Core.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<User> Users { get; init; }

        Task<int> SaveChangesAsync(CancellationToken cancellToken = default);
    }
}
