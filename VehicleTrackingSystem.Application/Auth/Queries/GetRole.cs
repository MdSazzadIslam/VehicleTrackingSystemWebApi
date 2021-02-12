using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTrackingSystem.Application.Auth.Queries
{
    public class GetRole : IRequest<IList<RoleDto>>
    {

        public GetRole()
        { 
        
        }

    }
}
