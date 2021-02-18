using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using VehicleTrackingSystem.Application.Handlers.Vehicle.Commands;
using VehicleTrackingSystem.Application.Handlers.Vehicle.Queries;

namespace VehicleTrackingSystem.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class VehicleController : ControllerBase
    {

        private readonly IMediator _mediator;
        private readonly ILogger<VehicleController> _logger;

        public VehicleController(IMediator mediator, ILogger<VehicleController> logger)
        {

            _mediator = mediator ?? throw new ArgumentNullException(nameof(_mediator));
            _logger = logger ?? throw new ArgumentException(nameof(_logger));

        }


        
        [HttpPost]
        public async Task<IActionResult> CreateVehicle(CreateVehicle command)
        {
            try
            {
                _logger.LogInformation("Vehicle method fired on {date}", DateTime.Now);
                var result = await _mediator.Send(command);
                _logger.LogInformation("Vehicle method task finished on {date}", DateTime.Now);
                return Ok(result);
            }
            catch (Exception e)
            {
                _logger.LogInformation("Vehicle method task finished on {date}", DateTime.Now);
                _logger.LogError($"Error in Vehicle method: {e.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError,
                   "Error in Vehicle method");

            }

        }

        
        [HttpPut]
        public async Task<IActionResult> UpdateVehicle(UpdateVehicle command, int id)
        {
            try
            {
                _logger.LogInformation("UpdateVehicle method fired on {date}", DateTime.Now);

                if (id != command.VehicleId)
                {
                    _logger.LogError("UpdateVehicle method error. Id not found... on {date}", DateTime.Now);

                    return BadRequest();
                }

                var result = await _mediator.Send(command);
                _logger.LogInformation("UpdateVehicle  method task finished on {date}", DateTime.Now);
                return Ok(result);
            }
            catch (Exception e)
            {
                _logger.LogInformation("UpdateVehicle  method task finished on {date}", DateTime.Now);
                _logger.LogError($"Error in UpdateVehicle  method: {e.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError,
                   "Error in UpdateVehicle  method");

            }

        }


        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVehicle(int id)
        {
            try
            {
                _logger.LogInformation("Delete vehicle Location method fired on {date}", DateTime.Now);
                var result = await _mediator.Send(new DeleteVehicle(id));
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

        
        [HttpGet]
        public async Task<IActionResult> GetVehicle()
        {
            try
            {
                _logger.LogInformation("Get vehicle method fired on {date}", DateTime.Now);
                var result = await _mediator.Send(new GetVehicle());
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

        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetVehicleById(int id)
        {
            try
            {
                _logger.LogInformation("Get vehicle method fired on {date}", DateTime.Now);
                var result = await _mediator.Send(new GetVehicleById(id));
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
