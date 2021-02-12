using VehicleTrackingSystem.Application.Common.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTrackingSystem.Application.Auth
{
    public interface IRoleService : IDisposable
    {

        public Task<Result> CreateRole(Application.Auth.RoleDto roleDto);
        public Task<Result> DeleteRole(int id);
        public Task<IList<Application.Auth.RoleDto>> GetRole();
        public Task<IList<Application.Auth.RoleDto>> GetRoleById(int id);
    }
}
