using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VehicleTrackingSystem.Application.Common.Models;

namespace VehicleTrackingSystem.Application.Handlers.Vehicle.Commands
{
    public class UpdateVehicleHandler : IRequestHandler<UpdateVehicle, ResultModel>
    {
        private readonly IVehicleService _vehicleService;
        private readonly IMapper _mapper;
        public UpdateVehicleHandler(IVehicleService vehicleService, IMapper mapper)
        {
            _vehicleService = vehicleService ?? throw new ArgumentNullException(nameof(_vehicleService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<ResultModel> Handle(UpdateVehicle request, CancellationToken cancellationToken)
        {
            var data = _mapper.Map<UpdateVehicleVm>(request);
            var result = await _vehicleService.UpdateVehicle(data);
            return result;
        }
    }
}
