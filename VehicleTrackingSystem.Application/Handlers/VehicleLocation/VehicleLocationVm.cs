using System;
using System.Collections.Generic;
using System.Text;
using VehicleTrackingSystem.Application.Common.Mappers;

namespace VehicleTrackingSystem.Application.Handlers.VehicleLocation
{
    public class VehicleLocationVm : IMapFrom<Domain.Entities.VehicleLocation>
    {
        public Int64 VehicleLocationId { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public DateTime TripDate { get; set; }
        public String TripTime { get; set; }
        public decimal? Speed { get; set; }
        public decimal? Heading { get; set; }
        public decimal? Altitude { get; set; }
        public short? Satellites { get; set; }
        public string Locality { get; set; }
        public Int64 VehicleId { get; set; }


    }
}
