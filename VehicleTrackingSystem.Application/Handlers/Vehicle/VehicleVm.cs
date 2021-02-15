﻿using System;
using System.Collections.Generic;
using System.Text;
using VehicleTrackingSystem.Application.Common.Mappers;

namespace VehicleTrackingSystem.Application.Handlers.Vehicle
{
    public class VehicleVM : IMapFrom<Domain.Entities.Vehicle>
    {

        public int VehicleId { get; set; }
        public string VehicleName { get; set; }
        public string ChassisNo { get; set; }
        public string ModelNo { get; set; }
        public string ColorCode { get; set; }
        public int ProductionYear { get; set; }
        public string CountryCode { get; set; }
        public string Remarks { get; set; }
        public char ActiveStatus { get; set; }


    }
}