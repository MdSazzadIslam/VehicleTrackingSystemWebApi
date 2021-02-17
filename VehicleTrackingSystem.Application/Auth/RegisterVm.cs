using System.ComponentModel.DataAnnotations;
using VehicleTrackingSystem.Application.Auth.Command;
using VehicleTrackingSystem.Application.Common.Mappers;


namespace VehicleTrackingSystem.Application.Auth
{
    public class RegisterVm : IMapFrom<RegisterUser>
    {

        public string Email { get; set; }
        public string Password { get; set; }
 
    }
 
}
