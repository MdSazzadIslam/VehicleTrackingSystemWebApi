using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;

using VehicleTrackingSystem.Application.Common.Interfaces;
using MediatR;

namespace VehicleTrackingSystem.Application.Auth.Command
{

    public class LoginUserHandler : IRequestHandler<LoginUser, object>
    {
        private readonly IIdentityService _identityService;
        private readonly IMapper _mapper;

        public LoginUserHandler(IIdentityService identityService, IMapper mapper)
        {
            _identityService = identityService ?? throw new ArgumentNullException(nameof(_identityService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<object> Handle(LoginUser request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<LoginDto>(request);

            return await _identityService.Login(user);
        }


    }

}
