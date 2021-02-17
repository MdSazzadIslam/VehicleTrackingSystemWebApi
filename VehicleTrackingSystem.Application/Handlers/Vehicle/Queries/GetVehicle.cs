using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using VehicleTrackingSystem.Domain.Entities;

namespace VehicleTrackingSystem.Application.Handlers.Vehicle.Queries
{
    public class GetVehicle : IRequest<IList<VehicleReturnVm>>
    {
        public GetVehicle()
        {

        }
    }
}
