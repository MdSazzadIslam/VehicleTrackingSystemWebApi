
using VehicleTrackingSystem.Application.Common.Models;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace VehicleTrackingSystem.Application.Auth.Command
{
    public class RegisterUser : IRequest<Result>
    {
        //[Required]
        //public string EmployeeId { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
       

        //public string PhoneNumber { get; set; }
        
        public string Password { get; set; }
        [Required]

        public int UserTypeId { get; set; }

        //[Required]
        //public string VendorId { get; set; }

        //[Required]
        //public string SellerId { get; set; }

        public RegisterUser(string email, string password, int userTypeId)
        {
           
            Password = password;
            //PhoneNumber = phoneNumber;
            Email = email;
            UserTypeId = userTypeId;

        }

 

    }
}
