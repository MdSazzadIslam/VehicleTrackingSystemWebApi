using VehicleTrackingSystem.Application.Common.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VehicleTrackingSystem.Application.Auth.Command
{
    public class DeleteRoleHandler : IRequestHandler<DeleteRole, Result>
    {
        private readonly IRoleService _roleService;
        public DeleteRoleHandler(IRoleService roleService)
        {
            _roleService = roleService ?? throw new ArgumentNullException(nameof(roleService));
        }
        public async Task<Result> Handle(DeleteRole request, CancellationToken cancellationToken)
        {
            var result = await _roleService.DeleteRole(request.Id);
            return result;
        }
    }
}
