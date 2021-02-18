using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTrackingSystem.Application.Handlers.BillPayment.Queries
{
    public class GetBillPaymentById : IRequest<BillPaymentReturnVm>
    {
        public int Id { get; set; }
        public GetBillPaymentById(int id)
        {
            Id = id;

        }

    }
}
