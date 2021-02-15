using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTrackingSystem.Infrastructure.Identity
{
    public class User : IdentityUser<int>
    {
        public string CountryCode { get; set; }
        public bool Deleted { get; set; }
        public int UserTypeId { get; set; }
        public string ActiveStatus { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
