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
        public Int64 DriverId { get; set; }

        [Column("DRIVER_NAME")]
        public string DriverName { get; set; }

        [Column("JOINING_DATE")]
        [DataType(DataType.Date)]
        public DateTime JoiningDate { get; set; }

        [Column("DATE_OF_BIRTH")]
        [DataType(DataType.Date)]
        public int DateOfBirth { get; set; }

        [Column("GENDER_ID")]
        public int GENDER_ID { get; set; }

        [Column("COUNTRY_CODE")]
        public int COUNTRY_CODE { get; set; }

        [Column("CONTACT_NO")]
        public string ContactNo { get; set; }

        [Column("EMAIL")]
        public string Email { get; set; }

        //Foreign key
        [Column("VEHICLE_ID")]
        public int VehicleId { get; set; }
        public virtual Vehicle VehicleInfos { get; set; }
    }
}
