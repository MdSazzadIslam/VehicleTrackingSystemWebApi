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
using VehicleTrackingSystem.Application.Handlers.Expense.Commands;
using VehicleTrackingSystem.Application.Handlers.Expense.Queries;

namespace VehicleTrackingSystem.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ExpenseController : ControllerBase
    {

        private readonly IMediator _mediator;
        private readonly ILogger<VehicleController> _logger;

        public ExpenseController(IMediator mediator, ILogger<VehicleController> logger)
        {

            _mediator = mediator ?? throw new ArgumentNullException(nameof(_mediator));
            _logger = logger ?? throw new ArgumentException(nameof(_logger));

        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> CreateExpense(CreateExpense command)
        {
            try
            {
                _logger.LogInformation("CreateExpense method fired on {date}", DateTime.Now);
                var result = await _mediator.Send(command);
                _logger.LogInformation("CreateExpense method task finished on {date}", DateTime.Now);
                return Ok(result);
            }
            catch (Exception e)
            {
                _logger.LogInformation("CreateExpense method task finished on {date}", DateTime.Now);
                _logger.LogError($"Error in CreateExpense method: {e.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError,
                   "Error in CreateExpense method");

            }

        }

        [AllowAnonymous]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExpense(int id)
        {
            try
            {
                _logger.LogInformation("DeleteExpense method fired on {date}", DateTime.Now);
                var result = await _mediator.Send(new DeleteExpense(id));
                _logger.LogInformation("DeleteExpense method task finished on {date}", DateTime.Now);
                return Ok(result);
            }
            catch (Exception e)
            {
                _logger.LogInformation("DeleteExpense method task finished on {date}", DateTime.Now);
                _logger.LogError($"Error in DeleteExpense method: {e.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError,
                   "Error in DeleteExpense method");

            }

        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> GetExpense()
        {
            try
            {
                _logger.LogInformation("GetVehicle method fired on {date}", DateTime.Now);
                var result = await _mediator.Send(new GetExpense());
                _logger.LogInformation("GetVehicle method task finished on {date}", DateTime.Now);
                return Ok(result);
            }
            catch (Exception e)
            {
                _logger.LogInformation("GetVehicle method task finished on {date}", DateTime.Now);
                _logger.LogError($"Error in GetVehicle method: {e.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError,
                   "Error in GetVehicle method");

            }

        }


        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetExpenseById(int id)
        {
            try
            {
                _logger.LogInformation("GetVehicleById method fired on {date}", DateTime.Now);
                var result = await _mediator.Send(new GetExpenseById(id));
                _logger.LogInformation("GetVehicleById method task finished on {date}", DateTime.Now);
                return Ok(result);
            }
            catch (Exception e)
            {
                _logger.LogInformation("GetVehicleById method task finished on {date}", DateTime.Now);
                _logger.LogError($"Error in GetVehicleById method: {e.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError,
                   "Error in GetVehicleById method");

            }

        }



    }
}
