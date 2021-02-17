using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VehicleTrackingSystem.Domain.Common;

namespace VehicleTrackingSystem.Domain.Entities
{
   [Table("VEHICLE")]
    public class Vehicle : AuditableEntity
    {
         
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("VEHICLE_ID")]
        public int VehicleId { get; set; }

        [Column("VEHICLE_NAME")]
        public string VehicleName { get; set; }

        [Column("MANUFACTURER_ID")]
        public Int64 ManufacturerId { get; set; }

        [Column("CHASSIS_NO")]
        public string ChassisNo { get; set; }

        [Column("MODEL_NO")]
        public string ModelNo { get; set; }

        [Column("COLOR_CODE")]
        public string ColorCode { get; set; }

        [Column("PRODUCTION_YEAR")]
        public int ProductionYear { get; set; }

        [Column("REGISTRATION_YEAR")]
        public int RegistrationYear { get; set; }

        [Column("ENGINE_CC")]
        public int EngineCC { get; set; }

        [Column("COUNTRY_CODE")]
        public string CountryCode { get; set; }

        [Column("REMARKS")]
        public string Remarks { get; set; }

        [Column("ACTIVE_STATUS")]
        public char ActiveStatus { get; set; }

        [Column("IMAGE_NAME")]
        public string ImageName { get; set; }

        [Column("DELETED")]
        public bool Deleted { get; set; }

        public virtual Owner Owner { get; set; }
    }
}
