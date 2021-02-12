using AutoMapper;
using VehicleTrackingSystem.Application.Auth;
using VehicleTrackingSystem.Application.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VehicleTrackingSystem.Application.Auth.Queries
{
    public class GetRegistrationHandler : IRequestHandler<GetRegistration, IList<RegisterDto>>
    {
        private readonly IRegistrationService _registrationService;
        private readonly IMapper _mapper;

        public GetRegistrationHandler(IRegistrationService registrationService, IMapper mapper)
        {
            _registrationService = registrationService ?? throw new ArgumentNullException(nameof(mapper));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<IList<RegisterDto>> Handle(GetRegistration request, CancellationToken cancellationToken)
        {
            var users = await _registrationService.GetRegistration();
            return _mapper.Map<IList<RegisterDto>>(users);
        }
    }
}
