using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using VehicleTrackingSystem.Application.Common.Models;
using VehicleTrackingSystem.Domain.Entities;

namespace VehicleTrackingSystem.Application.Handlers.Vehicle.Commands
{
    public class CreateVehicle : IRequest<ResultModel>
    {
        public int VehicleId { get; set; }
        public string VehicleName { get; set; }
        public int ManufacturerId { get; set; }
        public string ChassisNo { get; set; }
        public string ModelNo { get; set; }
        public string ColorCode { get; set; }
        public int ProductionYear { get; set; }
        public int RegistrationYear { get; set; }
        public int EngineeCC { get; set; }
        public string CountryCode { get; set; }
        public string Remarks { get; set; }
        public char ActiveStatus { get; set; }
        public string ImageName { get; set; }
        public Owner Owner { get; set; }
        public CreateVehicle(int vehicleId, string vehicleName, int ManufacturerId, string chassisNo, string modelNo, string colorCode, int productionYear, int registratinYear,int engineeCC, string countryCode, string remarks, string imageName, char activeStatus, Owner owner)
        {
            VehicleId = vehicleId;
            VehicleName = vehicleName;
            ChassisNo = chassisNo;
            ModelNo = modelNo;
            ColorCode = colorCode;
            ProductionYear = productionYear;
            RegistrationYear = registratinYear;
            EngineeCC = engineeCC;
            CountryCode = countryCode;
            Remarks = remarks;
            ActiveStatus = activeStatus;
            Owner = owner;
            ImageName = imageName;

        }

    }
}
