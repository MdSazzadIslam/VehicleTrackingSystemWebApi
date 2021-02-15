﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VehicleTrackingSystem.Domain.Entities
{
    [Table("PAYMENT")]
    public class Payment
    {
        [Key]
        [Column("PAYMENT_ID")]
        public Int64 PaymentId { get; set; }

        [Column("PAYMENT_MODE_ID")]
        public int PaymentModeId { get; set; }

        [Column("COUPON_CODE")]
        public string CouponCode { get; set; }

        [Column("PAYMENT_AMOUNT")]
        public double PaymentAmount { get; set; }

        [Column("DISCOUNT_AMOUNT")]
        public double DiscountAmount { get; set; }

        [Column("DUE_AMOUNT")]
        public double DueAmount { get; set; }

        [Column("NET_PAYMENT_AMOUNT")]
        public double NetPaymentAmount { get; set; }

        [Column("PAYMENT_STATUS")]
        public char PaymentStatus { get; set; }

        //Foreign Key
        [Column("CUSTOMER_ID")]
        public Int64 CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        //Foreign Key
        [Column("TRIP_ID")]
        public Int64 TripId { get; set; }
        public virtual TripRequest Trip { get; set; }

    }
}
