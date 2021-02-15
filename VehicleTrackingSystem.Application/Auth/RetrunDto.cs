using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTrackingSystem.Application.Auth
{
    public class ReturnDto
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string CountryCode { get; set; }
        public string ActiveStatus { get; set; }
        public int UserTypeId { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
    }
}
