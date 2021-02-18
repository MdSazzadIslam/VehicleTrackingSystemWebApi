using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VehicleTrackingSystem.Application.Handlers.VehicleLocation.Queries
{
    public class GetVehicleLocationByIdHandler : IRequestHandler<GetVehicleLocationById, VehicleLocationReturnVm>
    {
        private readonly IVehicleLocationService _vehicleLocationService;
        private readonly IMapper _mapper;

        public GetVehicleLocationByIdHandler(IVehicleLocationService vehicleService, IMapper mapper)
        {
            _vehicleLocationService = vehicleService ?? throw new ArgumentNullException(nameof(_vehicleLocationService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<VehicleLocationReturnVm> Handle(GetVehicleLocationById request, CancellationToken cancellationToken)
        {
            var vehicels = await _vehicleLocationService.GetVehicleLocationById(request.Id);
            return _mapper.Map<VehicleLocationReturnVm>(vehicels);
        }
    }
}
