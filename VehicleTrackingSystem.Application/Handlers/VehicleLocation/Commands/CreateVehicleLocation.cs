using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using VehicleTrackingSystem.Application.Common.Models;

namespace VehicleTrackingSystem.Application.Handlers.VehicleLocation.Commands
{
    public class CreateVehicleLocation : IRequest<ResultModel>
    {
        public int VehicleLocationId { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public DateTime TripDate { get; set; }
        public string TripTime { get; set; }
        public decimal? Speed { get; set; }
        public decimal? Altitude { get; set; }
        public int VehicleId { get; set; }

        public CreateVehicleLocation(int vehicleLocationId, decimal latitude, decimal longitude, DateTime tripDate, string tripTime, decimal speed, decimal altitude, int vehicleId)
        {

            VehicleLocationId = vehicleLocationId;
            Latitude = latitude;
            Longitude = longitude;
            tripDate = TripDate;
            TripTime = tripTime;
            Speed = speed;
            Altitude = altitude;
            VehicleId = vehicleId;

        }

    }
}
