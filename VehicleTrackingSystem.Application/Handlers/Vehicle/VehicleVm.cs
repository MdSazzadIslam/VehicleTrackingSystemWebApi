using VehicleTrackingSystem.Application.Common.Mappers;
using VehicleTrackingSystem.Application.Handlers.Vehicle.Commands;
using VehicleTrackingSystem.Domain.Entities;

namespace VehicleTrackingSystem.Application.Handlers.Vehicle
{
    public class VehicleVm : IMapFrom<CreateVehicle>
    {
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
        public Owner Owner { get; set; }


    }
}
