using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using VehicleTrackingSystem.Domain.Common;

namespace VehicleTrackingSystem.Domain.Entities
{
   [Table("VEHICLE_INFO")]
    public class Vehicle : AuditableEntity
    {
        [Key]
        [Column("VEHICLE_ID")]
        public Int64 VehicleId { get; set; }

        [Column("VEHICLE_NAME")]
        public string VehicleName { get; set; }

        [Column("CHASSIS_NO")]
        public string ChassisNo { get; set; }

        [Column("MODEL_NO")]
        public string ModelNo { get; set; }

        [Column("COLOR_CODE")]
        public string ColorCode { get; set; }

        [Column("PRODUCTION_YEAR")]
        public int ProductionYear { get; set; }

        [Column("COUNTRY_CODE")]
        public string CountryCode { get; set; }

        [Column("REMARKS")]
        public string Remarks { get; set; }

        [Column("ACTIVE_STATUS")]
        public char ActiveStatus { get; set; }
    }
}
