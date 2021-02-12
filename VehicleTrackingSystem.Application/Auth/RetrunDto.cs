using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTrackingSystem.Application.Auth
{
    public class ReturnDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string EmployeeId { get; set; }
        public string PhoneNumber { get; set; }
        public string ActiveStatus { get; set; }
        public int VendorId { get; set; }
        public int SellerId { get; set; }


    }
}
