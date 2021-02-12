using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VehicleTrackingSystem.Application.Auth.Queries
{
    public class GetRoleHandler : IRequestHandler<GetRole, IList<RoleDto>>
    {
        private readonly IRoleService _roleService;
        public GetRoleHandler(IRoleService roleService)
        {
            _roleService = roleService ?? throw new ArgumentNullException(nameof(_roleService));
        }
        public async Task<IList<RoleDto>> Handle(GetRole request, CancellationToken cancellationToken)
        {
            var roles = await _roleService.GetRole();
            return roles;
        }
    }
}
