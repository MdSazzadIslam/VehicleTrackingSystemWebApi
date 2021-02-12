using VehicleTrackingSystem.Application.Common.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTrackingSystem.Application.Auth.Command
{
    public class EmailConfirmation : IRequest<Result>
    {
       
        public string Email { get; set; }
        public EmailConfirmation(string email)
        {
           
            Email = email;
           

        }


    }
}
