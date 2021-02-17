using VehicleTrackingSystem.Application.Auth;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTrackingSystem.Application.Auth.Queries
{
    public class GetRegistrationById : IRequest<IList<RegisterVm>>
    {

        public string SearchBy { get; set; }

        public GetRegistrationById (string searchBy)
        {

            SearchBy = searchBy;
        }

    }
}
