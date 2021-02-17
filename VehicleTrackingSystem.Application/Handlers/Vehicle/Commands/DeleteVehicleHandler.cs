using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VehicleTrackingSystem.Application.Common.Interfaces;
using VehicleTrackingSystem.Application.Common.Models;

namespace VehicleTrackingSystem.Application.Handlers.Vehicle.Commands
{
    public class DeleteVehicleHandler : IRequestHandler<DeleteVehicle, ResultModel>
    {
        private readonly IVehicleService _vehicleService;
        private readonly ICurrentUserService _currentUserService;
        private readonly IDateTime _dateTime;

        public DeleteVehicleHandler(IVehicleService vehicleService, ICurrentUserService currentUserService, IDateTime dateTime)
        {

            _vehicleService = vehicleService ?? throw new ArgumentNullException(nameof(_vehicleService));
            _currentUserService = currentUserService ?? throw new ArgumentNullException(nameof(_currentUserService));
            _dateTime = dateTime ?? throw new ArgumentNullException(nameof(_dateTime));

        }

      
        public async Task<ResultModel> Handle(DeleteVehicle request, CancellationToken cancellationToken)
        {
            var result = await _vehicleService.DeleteVehicle(request.Id);
            return result;
        }
    }
}
