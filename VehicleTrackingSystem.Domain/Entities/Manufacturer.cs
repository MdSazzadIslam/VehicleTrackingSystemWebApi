using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using VehicleTrackingSystem.Domain.Common;

namespace VehicleTrackingSystem.Domain.Entities
{
    [Table("L_MANUFACTURER")]
    public class Manufacturer : AuditableEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("MANUFACTURER_ID")]
        public Int64 ManufacturerId { get; set; }

        [Column("MANUFACTURER_NAME")]
        public Int64 ManufacturerName { get; set; }
    }
}
