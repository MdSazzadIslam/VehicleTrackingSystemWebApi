using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTrackingSystem.Application.Handlers.VehicleLocation.Queries
{
    public class GetVehicleLocationById : IRequest<VehicleLocationReturnVm>
    {
        public int Id { get; set; }
        public GetVehicleLocationById(int id)
        {
            Id = id;

        }
    }
}
