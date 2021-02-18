using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VehicleTrackingSystem.Application.Common.Models;

namespace VehicleTrackingSystem.Application.Handlers.VehicleLocation.Commands
{
   public class UpdateVehicleLocationHandler : IRequestHandler<UpdateVehicleLocation, ResultModel>
    {
        private readonly IVehicleLocationService _vehicleLocationService;
        private readonly IMapper _mapper;
        public UpdateVehicleLocationHandler(IVehicleLocationService vehicleLocationService, IMapper mapper)
        {

            _vehicleLocationService = vehicleLocationService ?? throw new ArgumentNullException(nameof(_vehicleLocationService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));

        }

        public async Task<ResultModel> Handle(UpdateVehicleLocation request, CancellationToken cancellationToken)
        {
            var data = _mapper.Map<UpdateVehicleLocationVm>(request);
            var result = await _vehicleLocationService.UpdateVehicleLocation(data);
            return result;
        }
    }
}
