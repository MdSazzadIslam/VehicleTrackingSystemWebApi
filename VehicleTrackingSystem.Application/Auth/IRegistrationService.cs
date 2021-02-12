using VehicleTrackingSystem.Application.Auth;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTrackingSystem.Application.Auth
{
    public interface IRegistrationService : IDisposable
    {
        public Task<IList<RegisterDto>> GetRegistration();
        public Task<IList<RegisterDto>> GetRegistrationById(string searchBy);

    }
}
