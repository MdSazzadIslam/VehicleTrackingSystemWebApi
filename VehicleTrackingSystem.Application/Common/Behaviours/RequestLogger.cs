using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VehicleTrackingSystem.Application.Common.Interfaces;
using VehicleTrackingSystem.Application.Common.Models;
using MediatR.Pipeline;
using Microsoft.Extensions.Logging;

namespace VehicleTrackingSystem.Application.Common.Behaviours
{
    public class RequestLogger<TRequest> : IRequestPreProcessor<TRequest>
    {
        private readonly ILogger _logger;
        private readonly ICurrentUserService _currentUserService;
        private readonly ILogToDatabaseService _logToDatabaseService;

        public RequestLogger(ILogger<TRequest> logger, ICurrentUserService currentUserService, ILogToDatabaseService logToDatabaseService)
        {
            _logger = logger;
            _currentUserService = currentUserService;
            _logToDatabaseService = logToDatabaseService;
        }

        public async Task Process(TRequest request, CancellationToken cancellationToken)
        {
            var requestName = typeof(TRequest).Name;
            var userId = _currentUserService.UserId;
            var userName = _currentUserService.UserName;

            var logToDatabase = new RequestLoggerEntity
            {
                RequestName = requestName,
                UserId = userId,
                UserName = userName
            };

            await _logToDatabaseService.Save(logToDatabase, cancellationToken);

            _logger.LogInformation("Request: {Name} {@UserId} {@UserName} {@Request}",
                requestName, userId, userName, request);
        }
    }
}
