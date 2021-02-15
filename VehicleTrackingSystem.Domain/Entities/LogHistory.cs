using System;
using System.Collections.Generic;
using System.Text;
using VehicleTrackingSystem.Domain.Common;

namespace VehicleTrackingSystem.Domain.Entities
{
    public class LogHistory : AuditableEntity
    {

        public Int64 Id { get; set; }
        public string Data { get; set; }

    }
}
