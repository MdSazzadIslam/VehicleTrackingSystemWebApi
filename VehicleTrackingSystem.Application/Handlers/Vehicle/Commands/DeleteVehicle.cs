using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using VehicleTrackingSystem.Application.Common.Models;

namespace VehicleTrackingSystem.Application.Handlers.Vehicle.Commands
{
    public class DeleteVehicle : IRequest<ResultModel>
    {

        public int Id { get; set; }
        public DeleteVehicle(int id)
        {

            Id = id;
        }

    }
}
