using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTrackingSystem.Application.Common.Interfaces
{
    public interface ICurrentUserService
    {
        int UserId { get; }
        string UserName { get; }
        string EmployeeId { get; }
        string CountryCode { get; set; }
        public int VendorId { get; set; }
        public int SellerId { get; set; }
    }
}
