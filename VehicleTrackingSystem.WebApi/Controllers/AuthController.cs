using System;
using System.Threading.Tasks;
using VehicleTrackingSystem.Application.Auth.Command;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace Emarket.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class AuthController : ControllerBase
    {

        private readonly IMediator _mediator;
        public AuthController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginUser command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }


   
        [HttpPost("register")]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterUser command)
        {
            var result = await _mediator.Send(command);


            if (result.Succeed)
                return Ok(result.Message);

            return BadRequest(result.Errors);
        }
 

 

       

       

    }
}
