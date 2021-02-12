using VehicleTrackingSystem.Application.Common.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTrackingSystem.Application.Auth.Command
{
    public class DeleteRole : IRequest<Result>
    {
        public int Id { get; set; }
        public DeleteRole(int id)
        {

            Id = id;
        
        }

    }
}
