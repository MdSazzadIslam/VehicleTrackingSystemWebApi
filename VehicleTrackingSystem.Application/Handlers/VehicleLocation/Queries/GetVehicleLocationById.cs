using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTrackingSystem.Application.Handlers.VehicleLocation.Queries
{
    public class GetVehicleLocationById : IRequest<IList<Domain.Entities.VehicleLocation>>
    {
        public string SearchBy { get; set; }
        public GetVehicleLocationById(string searchBy)
        {
            SearchBy = searchBy;

        }
    }
}
