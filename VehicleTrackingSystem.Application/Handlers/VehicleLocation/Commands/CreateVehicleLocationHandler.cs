using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VehicleTrackingSystem.Application.Common.Interfaces;
using VehicleTrackingSystem.Application.Common.Models;

namespace VehicleTrackingSystem.Application.Handlers.VehicleLocation.Commands
{
    public class CreateVehicleLocationHandler : IRequestHandler<CreateVehicleLocation, Result>
    {
        private readonly IVehicleLocationService _vehicleLocationService;
        private readonly ICurrentUserService _currentUserService;
        private readonly IDateTime _dateTime;

        public CreateVehicleLocationHandler(IVehicleLocationService vehicleLocationService, ICurrentUserService currentUserService, IDateTime dateTime)
        {

            _vehicleLocationService = vehicleLocationService ?? throw new ArgumentNullException(nameof(_vehicleLocationService));
            _currentUserService = currentUserService ?? throw new ArgumentNullException(nameof(_currentUserService));
            _dateTime = dateTime ?? throw new ArgumentNullException(nameof(_dateTime));

        }

        public async Task<Result> Handle(CreateVehicleLocation request, CancellationToken cancellationToken)
        {
            var vehicles = new Domain.Entities.VehicleLocation
            {

                VehicleLocationId = request.VehicleLocationId,
                Latitude = request.Latitude,
                Longitude = request.Longitude,
                TripDate = request.TripDate,
                TripTime = request.TripTime,
                Speed = request.Speed,
                Heading = request.Heading,
                Altitude = request.Altitude,
                Satellites = request.Satellites,
                Locality = request.Locality,
                VehicleId = request.VehicleId

            };


            var result = await _vehicleLocationService.CreateVehicleLocation(vehicles);
            return result;
        }
    }
}
