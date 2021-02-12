using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VehicleTrackingSystem.Application.Common.Interfaces;
using VehicleTrackingSystem.Application.Common.Models;
using VehicleTrackingSystem.Infrastructure.Data;

namespace VehicleTrackingSystem.Infrastructure.Services
{
    public class LogToDatabaseService : ILogToDatabaseService
    {
        private readonly IDateTime _dateTime;
        private readonly AppDbContext _context;
        public LogToDatabaseService(AppDbContext context, IDateTime dateTime)
        {
            _context = context;
            _dateTime = dateTime;
        }
        public async Task<Result> Save(RequestLoggerEntity loggerEntity, CancellationToken cancellationToken)
        {
            loggerEntity.DateTime = _dateTime.Now;

            _context.LoggerEntities.Add(loggerEntity);

            await _context.SaveChangesAsync(cancellationToken);

            return Result.Success();
        }
    }
}
