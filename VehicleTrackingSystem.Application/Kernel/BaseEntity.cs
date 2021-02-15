using System;
using System.Collections.Generic;
using System.Text;

namespace Emarket.Application.Kernel
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public List<BaseDomainEvent> Events = new List<BaseDomainEvent>();
    }
}
