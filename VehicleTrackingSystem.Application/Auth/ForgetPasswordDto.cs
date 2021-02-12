using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTrackingSystem.Application.Auth
{
   public class ForgetPasswordDto
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }

    }
}
