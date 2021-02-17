using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VehicleTrackingSystem.Application.Handlers.VehicleLocation.Queries
{
    public class GetVehicleLocationHandler : IRequestHandler<GetVehicleLocation, IList<Domain.Entities.VehicleLocation>>
    {
        private readonly IVehicleLocationService _vehicleLocationService;
        private readonly IMapper _mapper;

        public GetVehicleLocationHandler(IVehicleLocationService vehicleService, IMapper mapper)
        {
            _vehicleLocationService = vehicleService ?? throw new ArgumentNullException(nameof(_vehicleLocationService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<IList<Domain.Entities.VehicleLocation>> Handle(GetVehicleLocation request, CancellationToken cancellationToken)
        {
            var vehicles = await _vehicleLocationService.GetVehicleLocation();
            return _mapper.Map<IList<Domain.Entities.VehicleLocation>>(vehicles);
        }
    }
}
