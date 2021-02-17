using System;
using System.Threading.Tasks;
using VehicleTrackingSystem.Application.Auth.Command;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;

namespace Emarket.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class AuthController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly IMediator _mediator;
        public AuthController(IMediator mediator, ILogger<AuthController> logger)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginUser command)
        {
            try
            {
                _logger.LogInformation("Login method fired on {date}", DateTime.Now);
                var result = await _mediator.Send(command);
                _logger.LogInformation("Login method task finished on {date}", DateTime.Now);
                return Ok(result);
            }
            catch(Exception e)
            {
                _logger.LogInformation("Login method task finished on {date}", DateTime.Now);
                _logger.LogError($"Error in Login method: {e.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError,
                   "Error in Login method");

            }

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
