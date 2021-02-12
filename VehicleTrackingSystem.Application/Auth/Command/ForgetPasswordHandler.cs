using AutoMapper;
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
    public class ForgetPasswordHandler : IRequestHandler<ForgetPassword, Result>
    {
        private readonly IIdentityService _identityService;
        private readonly IMapper _mapper;
        public ForgetPasswordHandler(IIdentityService identityService, IMapper mapper)
        {
            _identityService = identityService ?? throw new ArgumentNullException(nameof(_identityService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(_mapper));
        }
        public Task<Result> Handle(ForgetPassword request, CancellationToken cancellationToken)
        {
            // var result = _identityService.ForgetPassword(request.Email);
            // return result;
            return null;
        }
    }
}
