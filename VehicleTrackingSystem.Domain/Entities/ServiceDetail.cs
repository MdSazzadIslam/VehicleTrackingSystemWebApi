using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace VehicleTrackingSystem.Domain.Entities
{
    [Table("SERVICE_DETAIL")]
    public class ServiceDetail
    {
        [Key]
        [Column("SERVICE_DETAIL_ID")]
        public int ServiceDetailId { get; set; }
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
