using VehicleTrackingSystem.Application.Common.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VehicleTrackingSystem.Application.Auth.Command
{
    public class CreateRoleHandler : IRequestHandler<CreateRole, Result>
    {
        private readonly IRoleService _roleService;

        public CreateRoleHandler(IRoleService roleService)
        {
            _roleService = roleService ?? throw new ArgumentNullException(nameof(_roleService));


        }

        public async Task<Result> Handle(CreateRole request, CancellationToken cancellationToken)
        {
            var roles = new RoleDto
            {
                Id = request.Id,
                Name = request.Name

            };

            var result = await _roleService.CreateRole(roles);
            return result;
        }
    }
}
