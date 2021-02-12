using VehicleTrackingSystem.Application.Common.Interfaces;
using VehicleTrackingSystem.Application.Common.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VehicleTrackingSystem.Application.Auth.Command
{
    public class SetPasswordHandler : IRequestHandler<SetPassword, Result>
    { 
        private readonly IIdentityService _identityService;
        public SetPasswordHandler(IIdentityService identityService)
        {
            _identityService = identityService;
        }
        public async Task<Result> Handle(SetPassword request, CancellationToken cancellationToken)
        {
            //var result = await _identityService.SetPassword(request);
            // return result;
            return null;
        }
    }
}
