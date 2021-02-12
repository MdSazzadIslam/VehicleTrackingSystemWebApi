using VehicleTrackingSystem.Application.Auth;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTrackingSystem.Application.Auth.Queries
{
    public class GetRegistration : IRequest<IList<RegisterDto>>
    {
        public GetRegistration()
        {


        }

    }
}
