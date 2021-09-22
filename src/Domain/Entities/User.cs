using Rusv.UserManagement.Domain.Common;
using Rusv.UserManagement.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Rusv.UserManagement.Domain.Entities
{
    public class User : AuditableEntity
    {
        public string UserName { get; set; }

        public DateTime DateOfBirth { get; set; }

        [NotMapped]
        public Address Address { get; set; }

        public Gender Gender { get; set; }
    }    
}
