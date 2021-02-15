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
    public class CreateVehicleHandler : IRequestHandler<CreateVehicle, Result>
    {
        private readonly IVehicleService _vehicleService;
        private readonly ICurrentUserService _currentUserService;
        private readonly IDateTime _dateTime;

        public CreateVehicleHandler(IVehicleService vehicleService, ICurrentUserService currentUserService, IDateTime dateTime)
        {

            _vehicleService = vehicleService ?? throw new ArgumentNullException(nameof(_vehicleService));
            _currentUserService = currentUserService ?? throw new ArgumentNullException(nameof(_currentUserService));
            _dateTime = dateTime ?? throw new ArgumentNullException(nameof(_dateTime));

        }

        public async Task<Result> Handle(CreateVehicle request, CancellationToken cancellationToken)
        {

            var vechiles = new Domain.Entities.Vehicle
            {

                VehicleId = request.VehicleId,
                VehicleName = request.VehicleName,
                ChassisNo = request.ChassisNo,
                ModelNo = request.ModelNo,
                ColorCode = request.ColorCode,
                ProductionYear = request.ProductionYear,
                CountryCode = request.CountryCode,
                Remarks = request.Remarks,
                ActiveStatus = request.ActiveStatus


            };

            var result = await _vehicleService.CreateVehicle(vechiles);
            return result;
        }
    }
}
