using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Rusv.UserManagement.Infrastructure.Persistance;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Rusv.UserManagement.Core.Common.Interfaces;
using Rusv.UserManagement.Core.Users.Repository;
using Rusv.UserManagement.Infrastructure.Users.Repository;

namespace Rusv.UserManagement.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("PostgresDbConnection");

            services.AddDbContext<PostgreSqlDBContext>(options => options.UseNpgsql(connectionString));            
            services.AddScoped<IApplicationDbContext>(provider=> provider.GetService<PostgreSqlDBContext>());
            services.AddScoped<IUserRepository, UserRepository>();
            return services;
        }
    }
}
