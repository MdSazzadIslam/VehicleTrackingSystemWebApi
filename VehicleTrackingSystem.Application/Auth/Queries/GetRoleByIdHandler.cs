using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VehicleTrackingSystem.Application.Auth.Queries
{
    public class GetRoleByIdHandler : IRequestHandler<GetRoleById, IList<RoleDto>>
    {
        private readonly IRoleService _roleService;
        public GetRoleByIdHandler(IRoleService roleService)
        {
            _roleService = roleService ?? throw new ArgumentNullException(nameof(_roleService));
        }

        public async Task<IList<RoleDto>> Handle(GetRoleById request, CancellationToken cancellationToken)
        {
            var roles = await _roleService.GetRoleById(request.Id);
            return roles;
        }
    }
}
