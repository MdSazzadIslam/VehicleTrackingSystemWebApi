using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTrackingSystem.Application.Auth.Queries
{
    public class GetRoleById : IRequest<IList<RoleDto>>
    {
        public int Id { get; set; }
        public GetRoleById(int id)
        {
            Id = id;
        }
    }
}
