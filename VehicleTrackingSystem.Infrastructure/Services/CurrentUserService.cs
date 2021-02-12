using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using VehicleTrackingSystem.Application.Common.Interfaces;

namespace VehicleTrackingSystem.Infrastructure.Services
{
    public class CurrentUserService : ICurrentUserService
    {
        public CurrentUserService(IHttpContextAccessor httpContextAccessor)
        {
            UserId = Convert.ToInt32(httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier));
            EmployeeId = httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.SerialNumber);
            UserName = httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.Name);
            CountryCode = httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.Actor);

        }

        public int UserId { get; }
        public string EmployeeId { get; }
        public string UserName { get; }
        public string CountryCode { get; set; }
        public int VendorId { get; set; }
        public int SellerId { get; set; }

    }
}
