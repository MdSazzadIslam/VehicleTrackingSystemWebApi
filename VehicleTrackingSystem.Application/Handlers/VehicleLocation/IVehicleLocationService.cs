using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VehicleTrackingSystem.Application.Common.Models;

namespace VehicleTrackingSystem.Application.Handlers.VehicleLocation
{
    public interface IVehicleLocationService : IDisposable
    {

        public Task<Result> CreateVehicleLocation(Domain.Entities.VehicleLocation vehicleLocation);
        public Task<Result> DeleteVehicleLocation(int id);
        public Task<IList<Domain.Entities.VehicleLocation>> GetVehicleLocation();
        public Task<IList<Domain.Entities.VehicleLocation>> GetVehicleLocationById(string searchBy);
    }
}
