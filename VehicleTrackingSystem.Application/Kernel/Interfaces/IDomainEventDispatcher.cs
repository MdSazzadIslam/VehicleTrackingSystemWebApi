using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Emarket.Application.Kernel;

namespace Emarket.Application.kernel.Interfaces
{
    public interface IDomainEventDispatcher
    {
        Task Dispatch(BaseDomainEvent domainEvent);
    }
}
