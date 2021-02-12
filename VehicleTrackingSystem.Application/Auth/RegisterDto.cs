using VehicleTrackingSystem.Application.Auth.Command;
using VehicleTrackingSystem.Application.Common.Mappers;


namespace VehicleTrackingSystem.Application.Auth
{
    public class RegisterDto : IMapFrom<RegisterUser>
    {
        public string EmployeeId { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public int VendorId { get; set; }
        public int SellerId { get; set; }
        public int UserTypeId { get; set; }
        public string ActiveStatus { get; set; }
 
    }
 
}
