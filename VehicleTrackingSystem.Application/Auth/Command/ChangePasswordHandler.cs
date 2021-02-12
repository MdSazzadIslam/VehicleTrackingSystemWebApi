using AutoMapper;
using VehicleTrackingSystem.Application.Common.Interfaces;
using VehicleTrackingSystem.Application.Common.Models;
using VehicleTrackingSystem.Application.Auth;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VehicleTrackingSystem.Application.Auth.Command
{
    public class ChangePasswordHandler : IRequestHandler<ChangePassword, Result>
    {

        private readonly IIdentityService _identityService;
        private readonly IMapper _mapper;

        public ChangePasswordHandler(IIdentityService identityService, IMapper mapper)
        {
            _identityService = identityService ?? throw new ArgumentNullException(nameof(mapper));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<Result> Handle(ChangePassword request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<ChangePasswordDto>(request);
            return null;
            //return await _identityService.ChangePassword(user);
        }
    }
}
