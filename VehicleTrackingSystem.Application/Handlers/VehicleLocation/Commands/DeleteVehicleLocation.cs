using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using VehicleTrackingSystem.Application.Common.Models;

namespace VehicleTrackingSystem.Application.Handlers.VehicleLocation.Commands
{
    public class DeleteVehicleLocation : IRequest<Result>
    {
        public int Id { get; set; }
        public DeleteVehicleLocation(int id)
        {

            Id = id;
        }


    }
}
