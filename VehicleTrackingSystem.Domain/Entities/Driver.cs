using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VehicleTrackingSystem.Domain.Entities
{
    [Table("DRIVE_INFO")]
    public class Driver
    {
        [Key]
        [Column("DRIVER_ID")]
        public int DriverId { get; set; }

        [Column("DRIVER_NAME")]
        public string DriverName { get; set; }

        [Column("JOINING_DATE")]
        [DataType(DataType.Date)]
        public DateTime JoiningDate { get; set; }

        [Column("CONTACT_NO")]
        public string ContactNo { get; set; }

        [Column("EMAIL")]
        public string Email { get; set; }

        //Foreign key
        [Column("VEHICLE_ID")]
        public int VehicleId { get; set; }

        [ForeignKey("VEHICLE_ID")]
        public virtual Vehicle VehicleInfos { get; set; }
    }
}
