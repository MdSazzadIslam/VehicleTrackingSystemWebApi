using System;
using System.Collections.Generic;
using System.Text;

namespace Emarket.Application.Kernel
{
    public abstract class BaseDomainEvent
    {
        public DateTime DateOccurred { get; protected set; } = DateTime.UtcNow;
    }
}
