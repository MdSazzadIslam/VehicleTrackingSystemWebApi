using System;
using System.Collections.Generic;
using System.Text;
using VehicleTrackingSystem.Application.Common.Mappers;
using VehicleTrackingSystem.Application.Handlers.BillPayment.Commands;

namespace VehicleTrackingSystem.Application.Handlers.BillPayment
{
    public class BillPaymentVm : IMapFrom<CreateBillPayment>
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
