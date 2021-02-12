using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTrackingSystem.Application.Common.Models
{
    public class RequestLoggerEntity
    {
        public int Id { get; set; }
        public string RequestName { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public DateTime DateTime { get; set; }
    }
}
