using System;
using System.Collections.Generic;
using System.Text;
using VehicleTrackingSystem.Application.Common.Interfaces;
using VehicleTrackingSystem.Infrastructure.Utils;

namespace VehicleTrackingSystem.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => GetCurrentDateTime();

        public DateTime GetCurrentDateTime()
        {
            TimeZoneInfo timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(DateTimeConfig.DEFAULT_TIME_ZONE);
            return TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, timeZoneInfo);
        }
    }
}
