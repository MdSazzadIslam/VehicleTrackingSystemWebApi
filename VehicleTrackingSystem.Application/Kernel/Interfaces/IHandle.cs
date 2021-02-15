using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Emarket.Application.Kernel;

namespace Emarket.Application.kernel.Interfaces
{
    public interface IHandle<in T> where T : BaseDomainEvent
    {
        Task Handle(T domainEvent);
    }
}
