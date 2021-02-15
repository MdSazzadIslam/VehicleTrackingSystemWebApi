using VehicleTrackingSystem.Application.Common.Models;
using MediatR;


namespace VehicleTrackingSystem.Application.Auth.Command
{
    public class RegisterUser : IRequest<Result>
    {
       
        public string Email { get; set; }
        public string Password { get; set; }
        public RegisterUser(string email, string password)
        {
            Password = password;
            Email = email;

        }

 

    }
}
