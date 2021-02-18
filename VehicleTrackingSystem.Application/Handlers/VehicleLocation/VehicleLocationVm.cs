using System;
using VehicleTrackingSystem.Application.Common.Mappers;
using VehicleTrackingSystem.Application.Handlers.VehicleLocation.Commands;

namespace VehicleTrackingSystem.Application.Handlers.VehicleLocation
{
    public class VehicleLocationVm : IMapFrom<CreateVehicleLocation>
    {
        public int VehicleLocationId { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public DateTime TripDate { get; set; }
        public String TripTime { get; set; }
        public decimal? Speed { get; set; }
        public decimal? Altitude { get; set; }
        public Int64 VehicleId { get; set; }


    }
}
