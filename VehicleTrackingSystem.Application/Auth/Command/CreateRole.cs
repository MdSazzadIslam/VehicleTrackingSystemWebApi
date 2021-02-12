using VehicleTrackingSystem.Application.Common.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTrackingSystem.Application.Auth.Command
{
    public class CreateRole : IRequest<Result>
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public CreateRole(int id, string name)
        {
            Id = id;
            Name = name;
        }

    }
}
