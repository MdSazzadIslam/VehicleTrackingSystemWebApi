using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using VehicleTrackingSystem.Domain.Common;

namespace VehicleTrackingSystem.Domain.Entities
{
   [Table("VEHICLE_INFO")]
    public class VehicleInfo : AuditEntity
    {
        [Key]
        [Column("VEHICLE_ID")]
        public int VehicleId { get; set; }

        [Column("VEHICLE_NAME")]
        public string VehicleName { get; set; }

        [Column("CHASSIS_NO")]
        public string ChassisNo { get; set; }

        [Column("MODEL_NO")]
        public string ModelNo { get; set; }

        [Column("COLOR")]
        public string Color { get; set; }

        [Column("PRODUCTION_YEAR")]
        public string ProductionYear { get; set; }

        [Column("COUNTRY_NAME")]
        public string CountryName { get; set; }

        [Column("ACTIVE_STATUS")]
        public string ActiveStatus { get; set; }
    }
}
