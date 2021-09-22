using Microsoft.EntityFrameworkCore;
using Rusv.UserManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rusv.UserManagement.Domain.Entities
{
    [Keyless]
    public class Address : ValueObject
    {
        public string Area { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
