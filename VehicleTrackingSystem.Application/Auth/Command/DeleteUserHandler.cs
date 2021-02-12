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
    public class DeleteUserHandler : IRequestHandler<DeleteUser, Result>
    {

        private readonly IIdentityService _identityService;
        private readonly IMapper _mapper;

        public DeleteUserHandler( IIdentityService identityService, IMapper mapper)
        {
            _identityService = identityService;
            _mapper = mapper;

        }

        public async Task<Result> Handle(DeleteUser request, CancellationToken cancellationToken)
        {
            //var result = await _identityService.DeleteUser(request.Email);
            //return result;
            return null;
        }
    }
}
