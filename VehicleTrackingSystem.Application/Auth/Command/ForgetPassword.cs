using VehicleTrackingSystem.Application.Common.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTrackingSystem.Application.Auth.Command
{
  public class ForgetPassword : IRequest<Result>
    { 
        public string Email { get; set; }  
        public ForgetPassword(string email, string password)
        {
            Email = email;
            
        }
    }
}
