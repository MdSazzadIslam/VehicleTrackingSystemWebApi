using VehicleTrackingSystem.Application.Auth.Command;
using VehicleTrackingSystem.Application.Common.Mappers;
using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTrackingSystem.Application.Auth
{
    public class LoginDto : IMapFrom<LoginUser>
    {
        public string Email { get; set; }
        public string Password { get; set; }



    }
  
}
