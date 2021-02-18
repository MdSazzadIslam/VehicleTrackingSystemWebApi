using AutoMapper;
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
    public class CreateVehicleLocationHandler : IRequestHandler<CreateVehicleLocation, ResultModel>
    {
        private readonly IVehicleLocationService _vehicleLocationService;
        private readonly IMapper _mapper;
        public CreateVehicleLocationHandler(IVehicleLocationService vehicleLocationService, IMapper mapper)
        {

            _vehicleLocationService = vehicleLocationService ?? throw new ArgumentNullException(nameof(_vehicleLocationService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));

        }

        public async Task<ResultModel> Handle(CreateVehicleLocation request, CancellationToken cancellationToken)
        {
             
            var data = _mapper.Map<VehicleLocationVm>(request);
            var result = await _vehicleLocationService.CreateVehicleLocation(data);
            return result;
        }
    }
}
