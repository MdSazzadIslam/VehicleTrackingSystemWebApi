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
    public class DeleteVehicleLocationHandler : IRequestHandler<DeleteVehicleLocation, ResultModel>
    {
        private readonly IVehicleLocationService _vehicleLocationService;

        public DeleteVehicleLocationHandler(IVehicleLocationService vehicleLocationService, ICurrentUserService currentUserService, IDateTime dateTime)
        {

            _vehicleLocationService = vehicleLocationService ?? throw new ArgumentNullException(nameof(_vehicleLocationService));

        }

        public async Task<ResultModel> Handle(DeleteVehicleLocation request, CancellationToken cancellationToken)
        {
            var result = await _vehicleLocationService.DeleteVehicleLocation(request.Id);
            return result;

        }
    }
}
