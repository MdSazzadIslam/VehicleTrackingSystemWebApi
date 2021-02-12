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
    public class EmailConfirmationHandler : IRequestHandler<EmailConfirmation, Result>
    {
        private readonly IIdentityService _identityService;
        private readonly IMapper _mapper;

        public EmailConfirmationHandler(IIdentityService identityService, IMapper mapper)
        {
            _identityService = identityService ?? throw new ArgumentNullException(nameof(mapper));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<Result> Handle(EmailConfirmation request, CancellationToken cancellationToken)
        {

            //var result = await _identityService.EmailConfirmation(request.Email);
            return null;
            //return result;
        }
    }
}
