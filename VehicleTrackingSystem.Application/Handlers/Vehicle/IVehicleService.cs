using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VehicleTrackingSystem.Application.Common.Models;

namespace VehicleTrackingSystem.Application.Handlers.Vehicle
{
    public interface IVehicleService : IDisposable
    {

        public Task<Result> CreateVehicle(Domain.Entities.Vehicle vehicle);
        public Task<Result> DeleteVehicle(int id);
        public Task<IList<Domain.Entities.Vehicle>> GetVehicle();
        public Task<IList<Domain.Entities.Vehicle>> GetVehicleById(int id);

    }
}
