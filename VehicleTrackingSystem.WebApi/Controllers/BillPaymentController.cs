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
using VehicleTrackingSystem.Application.Handlers.BillPayment.Commands;
using VehicleTrackingSystem.Application.Handlers.BillPayment.Queries;

namespace VehicleTrackingSystem.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class BillPaymentController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<BillPaymentController> _logger;

        public BillPaymentController(IMediator mediator, ILogger<BillPaymentController> logger)
        {

            _mediator = mediator ?? throw new ArgumentNullException(nameof(_mediator));
            _logger = logger ?? throw new ArgumentException(nameof(_logger));

        }

        
        [HttpPost]
        public async Task<IActionResult> CreateBillPayment(CreateBillPayment command)
        {
            try
            {
                _logger.LogInformation("CreateBillPayment method fired on {date}", DateTime.Now);
                var result = await _mediator.Send(command);
                _logger.LogInformation("CreateBillPayment method task finished on {date}", DateTime.Now);
                return Ok(result);
            }
            catch (Exception e)
            {
                _logger.LogInformation("CreateBillPayment method task finished on {date}", DateTime.Now);
                _logger.LogError($"Error in CreateBillPayment method: {e.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError,
                   "Error in CreateBillPayment method");

            }

        }

        
        [HttpPut]
        public async Task<IActionResult> UpdateBillPayment(UpdateBillPayment command, int id)
        {
            try
            {
                _logger.LogInformation("UpdateBillPayment method fired on {date}", DateTime.Now);

                if (id != command.BillPaymentId)
                {
                    _logger.LogError("UpdateBillPayment method error. Id not found... on {date}", DateTime.Now);

                    return BadRequest();
                }

                var result = await _mediator.Send(command);
                _logger.LogInformation("UpdateBillPayment  method task finished on {date}", DateTime.Now);
                return Ok(result);
            }
            catch (Exception e)
            {
                _logger.LogInformation("UpdateBillPayment  method task finished on {date}", DateTime.Now);
                _logger.LogError($"Error in UpdateBillPayment  method: {e.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError,
                   "Error in UpdateBillPayment  method");

            }


        }


        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBillPayment(int id)
        {
            try
            {
                _logger.LogInformation("DeleteBillPayment method fired on {date}", DateTime.Now);
                var result = await _mediator.Send(new DeleteBillPayment(id));
                _logger.LogInformation("Delete DeleteBillPayment method task finished on {date}", DateTime.Now);
                return Ok(result);
            }
            catch (Exception e)
            {
                _logger.LogInformation("DeleteBillPayment method task finished on {date}", DateTime.Now);
                _logger.LogError($"Error in DeleteBillPayment method: {e.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError,
                   "Error in DeleteBillPayment method");

            }

        }

        
        [HttpGet]
        public async Task<IActionResult> GetBillPayment()
        {
            try
            {
                _logger.LogInformation("GetBillPayment method fired on {date}", DateTime.Now);
                var result = await _mediator.Send(new GetBillPayment());
                _logger.LogInformation("GetBillPayment method task finished on {date}", DateTime.Now);
                return Ok(result);
            }
            catch (Exception e)
            {
                _logger.LogInformation("GetBillPayment method task finished on {date}", DateTime.Now);
                _logger.LogError($"Error in GetBillPayment method: {e.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError,
                   "Error in GetBillPayment method");

            }

        }

        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBillPaymentById(int id)
        {
            try
            {
                _logger.LogInformation("GetBillPaymentById method fired on {date}", DateTime.Now);
                var result = await _mediator.Send(new GetBillPaymentById(id));
                _logger.LogInformation("GetBillPaymentById method task finished on {date}", DateTime.Now);
                return Ok(result);
            }
            catch (Exception e)
            {
                _logger.LogInformation("GetBillPaymentById task finished on {date}", DateTime.Now);
                _logger.LogError($"Error in GetBillPaymentById method: {e.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError,
                   "Error in GetBillPaymentById method");

            }

        }


    }
}
