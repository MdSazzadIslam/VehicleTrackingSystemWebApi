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
using VehicleTrackingSystem.Application.Handlers.ExpenseSubType.Commands;
using VehicleTrackingSystem.Application.Handlers.ExpenseSubType.Queries;

namespace VehicleTrackingSystem.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ExpenseSubTypeController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<ExpenseSubTypeController> _logger;

        public ExpenseSubTypeController(IMediator mediator, ILogger<ExpenseSubTypeController> logger)
        {

            _mediator = mediator ?? throw new ArgumentNullException(nameof(_mediator));
            _logger = logger ?? throw new ArgumentException(nameof(_logger));

        }

        
        [HttpPost]
        public async Task<IActionResult> CreateExpenseSubType(CreateExpenseSubType command)
        {
            try
            {
                _logger.LogInformation("CreateExpenseSubType method fired on {date}", DateTime.Now);
                var result = await _mediator.Send(command);
                _logger.LogInformation("CreateExpenseSubType method task finished on {date}", DateTime.Now);
                return Ok(result);
            }
            catch (Exception e)
            {
                _logger.LogInformation("CreateExpenseSubType method task finished on {date}", DateTime.Now);
                _logger.LogError($"Error in CreateExpenseSubType method: {e.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError,
                   "Error in CreateExpenseSubType method");

            }

        }

        
        [HttpPut]
        public async Task<IActionResult> UpdateExpenseSubType(UpdateExpenseSubType command, int id)
        {
            try
            {
                _logger.LogInformation("UpdateExpenseSubType method fired on {date}", DateTime.Now);

                if (id != command.ExpenseSubTypeId)
                {
                    _logger.LogError("UpdateExpenseSubType method error. Id not found... on {date}", DateTime.Now);

                    return BadRequest();
                }

                var result = await _mediator.Send(command);
                _logger.LogInformation("UpdateExpenseSubType  method task finished on {date}", DateTime.Now);
                return Ok(result);
            }
            catch (Exception e)
            {
                _logger.LogInformation("UpdateExpenseSubType  method task finished on {date}", DateTime.Now);
                _logger.LogError($"Error in UpdateExpenseSubType  method: {e.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError,
                   "Error in UpdateExpenseSubType  method");

            }

        }


        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExpenseSubType(int id)
        {
            try
            {
                _logger.LogInformation("DeleteExpenseSubType method fired on {date}", DateTime.Now);
                var result = await _mediator.Send(new DeleteExpenseSubType(id));
                _logger.LogInformation("DeleteExpenseSubType method task finished on {date}", DateTime.Now);
                return Ok(result);
            }
            catch (Exception e)
            {
                _logger.LogInformation("Delete expense sub type method task finished on {date}", DateTime.Now);
                _logger.LogError($"Error in Delete expense sub type method: {e.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError,
                   "Error in Delete expense sub type method");

            }

        }

        
        [HttpGet]
        public async Task<IActionResult> GetExpenseSubType()
        {
            try
            {
                _logger.LogInformation("Get GetExpenseSubType method fired on {date}", DateTime.Now);
                var result = await _mediator.Send(new GetExpenseSubType());
                _logger.LogInformation("Get GetExpenseSubType method task finished on {date}", DateTime.Now);
                return Ok(result);
            }
            catch (Exception e)
            {
                _logger.LogInformation("Get GetExpenseSubType method task finished on {date}", DateTime.Now);
                _logger.LogError($"Error in GetExpenseSubType method: {e.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError,
                   "Error in GetExpenseSubType method");

            }

        }

        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetExpenseSubTypeById(int id)
        {
            try
            {
                _logger.LogInformation("GetExpenseSubTypeById method fired on {date}", DateTime.Now);
                var result = await _mediator.Send(new GetExpenseSubTypeById(id));
                _logger.LogInformation("Get Bill payment method task finished on {date}", DateTime.Now);
                return Ok(result);
            }
            catch (Exception e)
            {
                _logger.LogInformation("GetExpenseSubTypeById method task finished on {date}", DateTime.Now);
                _logger.LogError($"Error in Get GetExpenseSubTypeById method: {e.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError,
                   "Error in GetExpenseSubTypeById method");

            }

        }

    }
}
