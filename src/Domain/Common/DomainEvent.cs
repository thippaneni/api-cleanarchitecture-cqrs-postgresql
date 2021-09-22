using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rusv.UserManagement.Domain.Common
{
    [Keyless]
    public abstract class DomainEvent
    {
        //public Guid Id { get; protected set; } = Guid.NewGuid();
        public bool IsPublished { get; set; }

        public DateTimeOffset DomainEventRaisedOn { get; protected set; } = DateTimeOffset.UtcNow;

        //protected DomainEvent()
        //{
        //    DomainEventRaisedOn = DateTimeOffset.UtcNow;
        //}
    }
}
