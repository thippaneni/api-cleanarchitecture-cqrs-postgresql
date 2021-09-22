using Rusv.UserManagement.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rusv.UserManagement.Core.Users.Dtos
{
    public class UpdateUserDto
    {        
        public DateTime DateOfBirth { get; set; }
        public string Area { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public Gender Gender { get; set; }
    }
}
