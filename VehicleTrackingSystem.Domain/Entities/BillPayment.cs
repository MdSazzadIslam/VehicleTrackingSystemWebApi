using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using VehicleTrackingSystem.Domain.Common;

namespace VehicleTrackingSystem.Domain.Entities
{
    public class BillPayment : AuditableEntity
    {
        [Key]
        [Column("BILL_PAYMENT_ID")]
        public int BillPaymentId { get; set; }

        [Column("BILL_NO")]
        public int BillNo { get; set; }

        [Column("BILLING_DATE")]
        [DataType(DataType.Date)]
        public DateTime PaymentDate { get; set; }

        [Column("BILLING_AMOUNT")]
        public double BillingAmount { get; set; }

        [Column("DISCOUNT_AMOUNT")]
        public double DiscountAmount { get; set; }

        [Column("DUE_AMOUNT")]
        public double DueAmount { get; set; }

        [Column("PAYMENT_AMOUNT")]
        public double PaymentAmount { get; set; }


    }
}
