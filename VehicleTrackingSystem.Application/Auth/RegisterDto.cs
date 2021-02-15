using System.ComponentModel.DataAnnotations;
using VehicleTrackingSystem.Application.Auth.Command;
using VehicleTrackingSystem.Application.Common.Mappers;


namespace VehicleTrackingSystem.Application.Auth
{
    public class RegisterDto : IMapFrom<RegisterUser>
    {
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Password { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        public string CountryCode { get; set; }
 
    }
 
}
