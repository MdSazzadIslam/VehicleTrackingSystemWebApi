using System;
using System.Collections.Generic;
using System.Text;
using VehicleTrackingSystem.Application.Common.Mappers;

namespace VehicleTrackingSystem.Application.Handlers.BillPayment
{
    public class BillPaymentVm : IMapFrom<Domain.Entities.BillPayment>
    {
        public int BillPaymentId { get; set; }
        public int BillNo { get; set; }
        public DateTime PaymentDate { get; set; }
        public double BillingAmount { get; set; }
        public double DiscountAmount { get; set; }
        public double DueAmount { get; set; }
        public double PaymentAmount { get; set; }

    }
}
