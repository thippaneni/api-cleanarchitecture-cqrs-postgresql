using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Rusv.UserManagement.Core.Common.Interfaces;
using Rusv.UserManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rusv.UserManagement.Infrastructure.Persistance
{
    public class PostgreSqlDBContext : DbContext, IApplicationDbContext
    {
        public PostgreSqlDBContext(DbContextOptions<PostgreSqlDBContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; init; }

        //public Task<int> SaveChangesAsync(CancellationToken cancellToken)
        //{
        //    ChangeTracker.DetectChanges();
        //    return base.SaveChange();
        //}
    }
}
