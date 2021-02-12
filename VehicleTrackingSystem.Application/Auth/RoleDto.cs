using VehicleTrackingSystem.Application.Auth.Command;
using VehicleTrackingSystem.Application.Common.Mappers;
using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTrackingSystem.Application.Auth
{
   public class RoleDto : IMapFrom<CreateRole>
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
     
}
