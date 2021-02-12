
using MediatR;
using VehicleTrackingSystem.Application.Common.Models;

namespace VehicleTrackingSystem.Application.Auth.Command
{
    public class ChangePassword : IRequest<Result>
    {

       
        //public string EmployeeId { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }

        public ChangePassword(string oldPassword, string newPassword)
        {

            OldPassword = oldPassword;
            NewPassword = newPassword;

        }

    }
}
