using VehicleTrackingSystem.Application.Common.Mappers;
using VehicleTrackingSystem.Application.Auth.Command;

namespace VehicleTrackingSystem.Application.Auth
{
    public class ChangePasswordDto : IMapFrom<ChangePassword>
    {
        public string EmployeeId { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }


    }
}
