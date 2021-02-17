using VehicleTrackingSystem.Application.Auth;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTrackingSystem.Application.Auth
{
    public interface IRegistrationService : IDisposable
    {
        public Task<IList<RegisterVm>> GetRegistration();
        public Task<IList<RegisterVm>> GetRegistrationById(string searchBy);

    }
}
