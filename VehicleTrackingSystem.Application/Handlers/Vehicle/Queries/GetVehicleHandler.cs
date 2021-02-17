using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VehicleTrackingSystem.Application.Handlers.Vehicle.Queries
{
    public class GetVehicleHandler : IRequestHandler<GetVehicle, IList<VehicleReturnVm>>
    {

        private readonly IVehicleService _vehicleService;
        private readonly IMapper _mapper;

        public GetVehicleHandler(IVehicleService vehicleService, IMapper mapper)
        {
            _vehicleService = vehicleService ?? throw new ArgumentNullException(nameof(vehicleService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<IList<VehicleReturnVm>> Handle(GetVehicle request, CancellationToken cancellationToken)
        {
            var vehicels = await _vehicleService.GetVehicle();
            return _mapper.Map<IList<VehicleReturnVm>>(vehicels);
        }
    }
}
