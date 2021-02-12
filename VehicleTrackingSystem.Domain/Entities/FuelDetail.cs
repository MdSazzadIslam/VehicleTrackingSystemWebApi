﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VehicleTrackingSystem.Domain.Entities
{
    [Table("FUEL_DETAIL")]
    public class FuelDetail
    {
        [Key]
        [Column("FUEL_DETAIL_ID")]
        public int FuelDetailId { get; set; }

        //Foreign Key
        [Column("VEHICLE_ID")]
        public int VehicleId { get; set; }

        [Column("BILL_NO")]
        public int BillNo { get; set; }

        [Column("BILLING_DATE")]
        [DataType(DataType.Date)]
        public DateTime BillingDate { get; set; }

        [Column("LITRE")]
        public double litre { get; set; }

        [Column("AMOUNT")]
        public double Amount { get; set; }

        [ForeignKey("VEHICLE_ID")]
        public virtual VehicleInfo VehicleInfos { get; set; }
    }
}
