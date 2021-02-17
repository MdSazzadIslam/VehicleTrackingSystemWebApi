using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VehicleTrackingSystem.Application.Auth;
using VehicleTrackingSystem.Application.Auth.Command;
using VehicleTrackingSystem.Application.Common.Models;

namespace VehicleTrackingSystem.Application.Common.Interfaces
{
    public interface IIdentityService
    {
        Task<object> Login(LoginDto loginDto);
        Task<(Result Result, int UserId)> Register(RegisterVm registerDto);
        //Task<Result> DeleteUser(string email);
        //Task<Result> ChangePassword(ChangePasswordDto user);
        //Task<Result> ForgetPassword(string Email);
        //Task<Result> SetPassword(SetPassword setPassword);
        //Task<Result> EmailConfirmation(string email); 
    }
}
