using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VehicleTrackingSystem.Application.Common.Models;

namespace VehicleTrackingSystem.Application.Handlers.VehicleLocation
{
    public interface IVehicleLocationService : IDisposable
    {

        public Task<ResultModel> CreateVehicleLocation(VehicleLocationVm vehicleLocationVm);
        public Task<ResultModel> UpdateVehicleLocation(UpdateVehicleLocationVm updateVehicleLocationVm);
        public Task<ResultModel> DeleteVehicleLocation(int id);
        public Task<IList<VehicleLocationReturnVm>> GetVehicleLocation();
        public Task<VehicleLocationReturnVm> GetVehicleLocationById(int id);
    }
}
