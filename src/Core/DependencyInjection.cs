using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Rusv.UserManagement.Core.Users.Repository;
using FluentValidation;

namespace Rusv.UserManagement.Core
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCore(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(typeof(IUserRepository));
            services.AddValidatorsFromAssembly(typeof(IValidator).Assembly);
            return services;
        }
    }
}
