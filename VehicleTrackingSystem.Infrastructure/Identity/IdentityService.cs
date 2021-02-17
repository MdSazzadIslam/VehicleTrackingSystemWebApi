using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using VehicleTrackingSystem.Application.Common.Exceptions;
using VehicleTrackingSystem.Application.Common.Models;

using VehicleTrackingSystem.Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using VehicleTrackingSystem.Application.Auth;


using VehicleTrackingSystem.Application.Common.Interfaces;
using VehicleTrackingSystem.Domain.Enums;

namespace VehicleTrackingSystem.Infrastructure.Identity
{ 
    public class IdentityService : IIdentityService
    { 
        private readonly AppDbContext _context;
        private readonly IConfiguration _config;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly ICurrentUserService _currentUserService;

        public IdentityService(AppDbContext context,
            IConfiguration config,
            UserManager<User> userManager,
            SignInManager<User> signInManager,

            ICurrentUserService currentUserService)
        {
            _context = context;
            _config = config;
            _userManager = userManager;
            _signInManager = signInManager;
         
            _currentUserService = currentUserService;
        }

        public async Task<Result> DeleteUser(string email)
        {

            if (email != null)
            {
                var user = await _context.Users.FirstOrDefaultAsync(x => x.Email == email && !x.Deleted);
                user.Deleted = true;
                await _context.SaveChangesAsync();
                return (Result.Success("User Deleted Successfully.."));
            }
            else
            {
                return (Result.Failure(new List<string> { "User Not Found!!" }));
            }

        }


        public async Task<object> Login(LoginDto loginDto)
        {
            if (!string.IsNullOrWhiteSpace(loginDto.Email) && !string.IsNullOrWhiteSpace(loginDto.Password))
            {

                var checkUser = await _context.Users.FirstOrDefaultAsync(c => c.Deleted == true);
                if (checkUser != null)
                    return (Result.Failure(new List<string> { "User deleted!!!" }), checkUser.Id);

                var user = await _context.Users.FirstOrDefaultAsync(c => c.Email == loginDto.Email) ??
                           (await _userManager.FindByEmailAsync(loginDto.Email) ?? await _userManager.FindByEmailAsync(loginDto.Email));



                if (user == null)
                {
                    throw new UnauthorizedAccessException("User not found! Please register");
                }

                if (user.ActiveStatus != "Y")
                {
                    throw new UnauthorizedAccessException("User not active yet!!!");
                }

                var result = await _signInManager.CheckPasswordSignInAsync(user, loginDto.Password, false);

                if (result.Succeeded)
                {
                    ReturnDto appUser = new ReturnDto
                    {
                        Id = user.Id,
                        Email = user.Email,
                        PhoneNumber = user.PhoneNumber,
                        CountryCode = user.CountryCode,
                        ActiveStatus = user.ActiveStatus,
                        UserTypeId = user.UserTypeId,
                        PhoneNumberConfirmed = user.PhoneNumberConfirmed,
                        TwoFactorEnabled = user.TwoFactorEnabled
                    };

                    return new
                    {
                        token = GenerateJwtToken(user).Result,
                        user = appUser
                    };
                }

                throw new UnauthorizedAccessException("Invalid Email or Password!!!");
            }


            throw new NotFoundException(nameof(User), loginDto.Email);
        }
        public async Task<(Result Result, int UserId)> Register(RegisterVm registerDto)
        {

            var checkUser = await _context.Users.FirstOrDefaultAsync(c => c.Email == registerDto.Email);
            if (checkUser != null)
                return (Result.Failure(new List<string> { "Email Already Exist" }), checkUser.Id);

            if (checkUser == null)
            {
                var user = new User
                {
                    UserName= Guid.NewGuid().ToString(),
                    Email = registerDto.Email,
                    ActiveStatus = "Y",
                    UserTypeId = 1
            };

                var result = await _userManager.CreateAsync(user, registerDto.Password);

                if (result.Succeeded)
                {
                    var userForRole = await _userManager.FindByNameAsync(user.UserName);
                    await _userManager.AddToRolesAsync(userForRole, new[] { UsersRole.Admin.ToString() });
                }
                return (result.ToApplicationResult(), user.Id);
            }
            else
            {
                return (Result.Failure(new List<string> { "No User Found" }), checkUser.Id);
            }

        }
        private async Task<string> GenerateJwtToken(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Email, user.Email),

            };

          
            var roles = await _userManager.GetRolesAsync(user);

            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.GetSection("AppSettings:Token").Value));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = creds
            };

            var tokenHandler = new JwtSecurityTokenHandler();

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }






    }
}
