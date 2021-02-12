using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using VehicleTrackingSystem.Application.Common.Interfaces;
using VehicleTrackingSystem.Application.Common.Models;
using MediatR;

namespace VehicleTrackingSystem.Application.Auth.Command
{
    public class RegisterUserHandler : IRequestHandler<RegisterUser, Result>
    {
        private readonly IIdentityService _identityService;
        private readonly IMapper _mapper;

        public RegisterUserHandler(IIdentityService identityService, IMapper mapper)
        {
            _identityService = identityService ?? throw new ArgumentNullException(nameof(mapper));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<Result> Handle(RegisterUser request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<RegisterDto>(request);

            var result = await _identityService.Register(user);

            return result.Result;
        }
    }
}
