using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleTrackingSystem.Application.Handlers.ExpenseType.Commands;
using VehicleTrackingSystem.Application.Handlers.ExpenseType.queries;

namespace VehicleTrackingSystem.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ExpenseTypeController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<ExpenseTypeController> _logger;

        public ExpenseTypeController(IMediator mediator, ILogger<ExpenseTypeController> logger)
        {

            _mediator = mediator ?? throw new ArgumentNullException(nameof(_mediator));
            _logger = logger ?? throw new ArgumentException(nameof(_logger));

        }

        
        [HttpPost]
        public async Task<IActionResult> CreateExpenseType(CreateExpenseType command)
        {
            try
            {
                _logger.LogInformation("CreateExpenseType method fired on {date}", DateTime.Now);
                var result = await _mediator.Send(command);
                _logger.LogInformation("CreateExpenseType method task finished on {date}", DateTime.Now);
                return Ok(result);
            }
            catch (Exception e)
            {
                _logger.LogInformation("CreateExpenseType method task finished on {date}", DateTime.Now);
                _logger.LogError($"Error in CreateExpenseType method: {e.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError,
                   "Error in CreateExpenseType method");

            }

        }

        
        [HttpPut]
        public async Task<IActionResult> UpdateExpenseType(UpdateExpenseType command, int id)
        {
            try
            {
                _logger.LogInformation("UpdateExpenseType method fired on {date}", DateTime.Now);

                if (id != command.ExpenseTypeId)
                {
                    _logger.LogError("UpdateExpenseType method error. Id not found... on {date}", DateTime.Now);

                    return BadRequest();
                }

                var result = await _mediator.Send(command);
                _logger.LogInformation("UpdateExpenseType  method task finished on {date}", DateTime.Now);
                return Ok(result);
            }
            catch (Exception e)
            {
                _logger.LogInformation("UpdateExpenseType  method task finished on {date}", DateTime.Now);
                _logger.LogError($"Error in UpdateExpenseType  method: {e.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError,
                   "Error in UpdateExpenseType  method");

            }

        }

        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExpenseType(int id)
        {
            try
            {
                _logger.LogInformation("DeleteExpenseType method fired on {date}", DateTime.Now);
                var result = await _mediator.Send(new DeleteExpenseType(id));
                _logger.LogInformation("DeleteExpenseType method task finished on {date}", DateTime.Now);
                return Ok(result);
            }
            catch (Exception e)
            {
                _logger.LogInformation("DeleteExpenseType method task finished on {date}", DateTime.Now);
                _logger.LogError($"Error in DeleteExpenseType method: {e.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError,
                   "Error in DeleteExpenseType method");

            }

        }

        
        [HttpGet]
        public async Task<IActionResult> GetExpenseType()
        {
            try
            {
                _logger.LogInformation("GetExpenseType method fired on {date}", DateTime.Now);
                var result = await _mediator.Send(new GetExpenseType());
                _logger.LogInformation("GetExpenseType method task finished on {date}", DateTime.Now);
                return Ok(result);
            }
            catch (Exception e)
            {
                _logger.LogInformation("GetExpenseType method task finished on {date}", DateTime.Now);
                _logger.LogError($"Error in GetExpenseType method: {e.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError,
                   "Error in GetExpenseType method");

            }

        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetExpenseTypeById(int id)
        {
            try
            {
                _logger.LogInformation("GetExpenseTypeById method fired on {date}", DateTime.Now);
                var result = await _mediator.Send(new GetExpenseTypeById(id));
                _logger.LogInformation("GetExpenseTypeById method task finished on {date}", DateTime.Now);
                return Ok(result);
            }
            catch (Exception e)
            {
                _logger.LogInformation("GetExpenseTypeById task finished on {date}", DateTime.Now);
                _logger.LogError($"Error in GetExpenseTypeById method: {e.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError,
                   "Error in GetExpenseTypeById method");

            }

        }


    }
}
