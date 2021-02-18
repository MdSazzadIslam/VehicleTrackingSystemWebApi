using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VehicleTrackingSystem.Application.Common.Models;

namespace VehicleTrackingSystem.Application.Handlers.Vehicle
{
    public interface IVehicleService : IDisposable
    {

        public Task<ResultModel> CreateVehicle(VehicleVm vehicleVm);
        public Task<ResultModel> UpdateVehicle(UpdateVehicleVm vehicleVm);
        public Task<ResultModel> DeleteVehicle(int id);
        public Task<IList<VehicleReturnVm>> GetVehicle();
        public Task<VehicleReturnVm> GetVehicleById(int id);

    }
}
