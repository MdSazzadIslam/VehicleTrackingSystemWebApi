using System;
using System.Collections.Generic;
using System.Text;
using VehicleTrackingSystem.Domain.Common;

namespace VehicleTrackingSystem.Domain.Entities
{
    public class LogHistory : AuditableEntity
    {

        public int Id { get; set; }
        public string Data { get; set; }

    }
}
