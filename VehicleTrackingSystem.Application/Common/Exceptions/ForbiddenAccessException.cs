using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTrackingSystem.Application.Common.Exceptions
{
    public class ForbiddenAccessException : Exception
    {
        public ForbiddenAccessException() : base() { }
    }
}
