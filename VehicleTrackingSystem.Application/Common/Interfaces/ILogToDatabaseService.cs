using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VehicleTrackingSystem.Application.Common.Models;

namespace VehicleTrackingSystem.Application.Common.Interfaces
{
    public interface ILogToDatabaseService
    {
        Task<Result> Save(RequestLoggerEntity loggerEntity, CancellationToken cancellationToken);
    }
}
