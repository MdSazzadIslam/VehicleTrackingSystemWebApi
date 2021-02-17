using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTrackingSystem.Application.Handlers.VehicleLocation.Queries
{
    public class GetVehicleLocation : IRequest<IList<Domain.Entities.VehicleLocation>>
    {
        public GetVehicleLocation()
        {

        }
    }
}
