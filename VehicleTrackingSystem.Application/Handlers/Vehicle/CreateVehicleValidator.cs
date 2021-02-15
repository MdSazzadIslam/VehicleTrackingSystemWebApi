using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using VehicleTrackingSystem.Application.Handlers.Vehicle.Commands;

namespace VehicleTrackingSystem.Application.Handlers.Vehicle
{
    public class CreateVehicleValidator : AbstractValidator<CreateVehicle>
    {
        public CreateVehicleValidator()
        {

            RuleFor(v => v.VehicleName).NotEmpty().WithMessage("Please enter vehicle name!!!").MinimumLength(5).WithMessage("At least 5 character");
            RuleFor(v => v.ChassisNo).NotEmpty().WithMessage("Please enter chassis number!!!");
            RuleFor(v => v.ModelNo).NotEmpty().WithMessage("Please enter model number!!!");
            RuleFor(v => v.ColorCode).NotEmpty().WithMessage("Please enter color code!!!");
            RuleFor(v => v.ProductionYear).NotEmpty().WithMessage("Please enter product year!!!").Equal(4);
            RuleFor(v => v.CountryCode).NotEmpty().WithMessage("Please enter country name!!!");
         
        }


    }
}
