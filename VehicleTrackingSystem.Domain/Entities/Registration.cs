using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTrackingSystem.Domain.Entities
{
    public class Registration
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Int32 NidNo { get; set; }
        public string ContactNo { get; set; }
        public int UserTypeId { get; set; }
    }
}
