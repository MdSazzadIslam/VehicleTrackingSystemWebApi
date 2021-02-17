using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTrackingSystem.Application.Handlers.BillPayment.Queries
{
    public class GetBillPaymentById : IRequest<IList<Domain.Entities.BillPayment>>
    {
        public string SearchBy { get; set; }
        public GetBillPaymentById(string searchBy)
        {
            SearchBy = searchBy;

        }

    }
}
