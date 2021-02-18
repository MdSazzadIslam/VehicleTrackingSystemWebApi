using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using VehicleTrackingSystem.Application.Common.Models;

namespace VehicleTrackingSystem.Application.Handlers.BillPayment.Commands
{
    public class CreateBillPayment : IRequest<ResultModel>
    {
        public int BillNo { get; set; }
        public DateTime PaymentDate { get; set; }
        public double BillingAmount { get; set; }
        public double DiscountAmount { get; set; }
        public double DueAmount { get; set; }
        public double PaymentAmount { get; set; }

        public CreateBillPayment(int billNo, DateTime paymentDate, double billingAmount, double discountAmount, double dueAmount, double paymentAmount)
        {
          
            BillNo = billNo;
            PaymentDate = paymentDate;
            BillingAmount = billingAmount;
            DiscountAmount = discountAmount;
            DueAmount = dueAmount;
            PaymentAmount = paymentAmount;

        }


    }
}
