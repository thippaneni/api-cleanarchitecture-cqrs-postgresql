using System;
using System.Collections.Generic;
using System.Text;

namespace Rusv.UserManagement.Domain.Common
{
    public abstract class AuditableEntity : BaseEntity
    {
        public DateTime CreatedOn { get; protected set; } = DateTime.UtcNow;
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public string LastModifiedBy { get; set; }
    }
}
