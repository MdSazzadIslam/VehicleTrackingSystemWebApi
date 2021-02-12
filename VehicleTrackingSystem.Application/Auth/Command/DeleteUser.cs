using System;
using System.Collections.Generic;
using System.Text;
using VehicleTrackingSystem.Application.Common.Models;
using MediatR;

namespace VehicleTrackingSystem.Application.Auth.Command
{
    public class DeleteUser :IRequest<Result>
    {
        public string Email { get; set; }


        public DeleteUser(string email)
        {

            Email = email;
        }

    }
}
