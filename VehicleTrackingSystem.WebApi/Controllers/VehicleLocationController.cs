using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using VehicleTrackingSystem.Application.Handlers.VehicleLocation.Commands;
using VehicleTrackingSystem.Application.Handlers.VehicleLocation.Queries;

namespace VehicleTrackingSystem.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class VehicleLocationController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<VehicleLocationController> _logger;

        public VehicleLocationController(IMediator mediator, ILogger<VehicleLocationController> logger)
        {

            _mediator = mediator ?? throw new ArgumentNullException(nameof(_mediator));
            _logger = logger ?? throw new ArgumentException(nameof(_logger));

        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> CreateVehicleLocation(CreateVehicleLocation command)
        {
            try
            {
                _logger.LogInformation("Vehicle Location method fired on {date}", DateTime.Now);
                var result = await _mediator.Send(command);
                _logger.LogInformation("Vehicle Location method task finished on {date}", DateTime.Now);
                return Ok(result);
            }
            catch (Exception e)
            {
                _logger.LogInformation("Vehicle Location method task finished on {date}", DateTime.Now);
                _logger.LogError($"Error in Vehicle Location method: {e.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError,
                   "Error in Vehicle Location method");

            }

        }

        [AllowAnonymous]
        [HttpPut]
        public async Task<IActionResult> UpdateVehicleLocation (UpdateVehicleLocation command, int id)
        {
            try
            {
                _logger.LogInformation("UpdateVehicleLocation method fired on {date}", DateTime.Now);
             
                if(id != command.VehicleLocationId)
                {
                    _logger.LogError("UpdateVehicleLocation method error. Id not found... on {date}", DateTime.Now);
                  
                    return BadRequest();
                }

                var result = await _mediator.Send(command);
                _logger.LogInformation("UpdateVehicleLocation  method task finished on {date}", DateTime.Now);
                return Ok(result);
            }
            catch (Exception e)
            {
                _logger.LogInformation("UpdateVehicleLocation  method task finished on {date}", DateTime.Now);
                _logger.LogError($"Error in UpdateVehicleLocation  method: {e.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError,
                   "Error in UpdateVehicleLocation  method");

            }

        }

        [AllowAnonymous]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DE(int id)
        {
            try
            {
                _logger.LogInformation("Delete vehicle Location method fired on {date}", DateTime.Now);
                var result = await _mediator.Send(new DeleteVehicleLocation(id));
                _logger.LogInformation("Delete vehicle Location method task finished on {date}", DateTime.Now);
                return Ok(result);
            }
            catch (Exception e)
            {
                _logger.LogInformation("Delete vehicle method task finished on {date}", DateTime.Now);
                _logger.LogError($"Error in Delete vehicle method: {e.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError,
                   "Error in Delete vehicle method");

            }

        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> GetVehicle()
        {
            try
            {
                _logger.LogInformation("Get vehicle Location method fired on {date}", DateTime.Now);
                var result = await _mediator.Send(new GetVehicleLocation());
                _logger.LogInformation("Get vehicle Location method task finished on {date}", DateTime.Now);
                return Ok(result);
            }
            catch (Exception e)
            {
                _logger.LogInformation("Get vehicle Location method task finished on {date}", DateTime.Now);
                _logger.LogError($"Error in Get vehicle method: {e.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError,
                   "Error in Get vehicle method");

            }

        }

        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetVehicleById(int id)
        {
            try
            {
                _logger.LogInformation("Get vehicle Location method fired on {date}", DateTime.Now);
                var result = await _mediator.Send(new GetVehicleLocationById(id));
                _logger.LogInformation("Get vehicle Location method task finished on {date}", DateTime.Now);
                return Ok(result);
            }
            catch (Exception e)
            {
                _logger.LogInformation("Get vehicle method task finished on {date}", DateTime.Now);
                _logger.LogError($"Error in Get vehicle method: {e.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError,
                   "Error in Get vehicle method");

            }

        }

    }
}
