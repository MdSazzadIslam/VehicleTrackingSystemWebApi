using System;
using System.Collections.Generic;
using System.Text;
using VehicleTrackingSystem.Application.Common.Mappers;
using VehicleTrackingSystem.Domain.Entities;

namespace VehicleTrackingSystem.Application.Handlers.Vehicle
{
    public class VehicleReturnVm : IMapFrom<Domain.Entities.Vehicle>
    {
        public int VehicleId { get; set; }
        public string VehicleName { get; set; }
        public int ManufacturerId { get; set; }
        public string ChassisNo { get; set; }
        public string ModelNo { get; set; }
        public string ColorCode { get; set; }
        public int ProductionYear { get; set; }
        public int RegistrationYear { get; set; }
        public int EngineCC { get; set; }
        public string CountryCode { get; set; }
        public string Remarks { get; set; }
        public char ActiveStatus { get; set; }
        public string ImageName { get; set; }
        public virtual Owner Owner { get; set; }

    }
}
