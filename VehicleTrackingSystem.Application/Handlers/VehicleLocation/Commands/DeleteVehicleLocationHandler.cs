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
    public class DeleteVehicleLocationHandler : IRequestHandler<DeleteVehicleLocation, Result>
    {
        private readonly IVehicleLocationService _vehicleLocationService;
        private readonly ICurrentUserService _currentUserService;
        private readonly IDateTime _dateTime;

        public DeleteVehicleLocationHandler(IVehicleLocationService vehicleLocationService, ICurrentUserService currentUserService, IDateTime dateTime)
        {

            _vehicleLocationService = vehicleLocationService ?? throw new ArgumentNullException(nameof(_vehicleLocationService));
            _currentUserService = currentUserService ?? throw new ArgumentNullException(nameof(_currentUserService));
            _dateTime = dateTime ?? throw new ArgumentNullException(nameof(_dateTime));

        }

        public async Task<Result> Handle(DeleteVehicleLocation request, CancellationToken cancellationToken)
        {
            var result = await _vehicleLocationService.DeleteVehicleLocation(request.Id);
            return result;

        }
    }
}
