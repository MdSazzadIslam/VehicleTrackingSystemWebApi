using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VehicleTrackingSystem.Application.Handlers.Vehicle.Queries
{
    public class GetVehicleByIdHandler : IRequestHandler<GetVehicleById, VehicleReturnVm>
    {
        private readonly IVehicleService _vehicleService;
        private readonly IMapper _mapper;

        public GetVehicleByIdHandler(IVehicleService vehicleService, IMapper mapper)
        {
            _vehicleService = vehicleService ?? throw new ArgumentNullException(nameof(vehicleService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<VehicleReturnVm> Handle(GetVehicleById request, CancellationToken cancellationToken)
        {
            var vehicles = await _vehicleService.GetVehicleById(request.Id);
            return _mapper.Map<VehicleReturnVm>(vehicles);
        }
    }
}
