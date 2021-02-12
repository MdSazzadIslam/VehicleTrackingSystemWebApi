using MediatR;

namespace VehicleTrackingSystem.Application.Auth.Command
{
    public class LoginUser : IRequest<object>
    {
        public string Email { get; set; }
        public string Password { get; set; }

     
        public LoginUser(string email, string password)
        {
            Email = email;
            Password = password;

        }
    }
}
