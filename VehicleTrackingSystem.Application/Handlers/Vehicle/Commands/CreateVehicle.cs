using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using VehicleTrackingSystem.Application.Common.Models;

namespace VehicleTrackingSystem.Application.Handlers.Vehicle.Commands
{
    public class CreateVehicle : IRequest<Result>
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

        public CreateVehicle(int vehicleId, string vehicleName, string chassisNo, string modelNo, string colorCode, int productionYear, string countryCode, string remarks, char activeStatus)
        {
            VehicleId = vehicleId;
            VehicleName = vehicleName;
            ChassisNo = chassisNo;
            ModelNo = modelNo;
            ColorCode = colorCode;
            ProductionYear = productionYear;
            CountryCode = countryCode;
            Remarks = remarks;
            ActiveStatus = activeStatus;



        }

    }
}
