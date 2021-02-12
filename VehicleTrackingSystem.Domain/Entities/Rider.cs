using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VehicleTrackingSystem.Domain.Entities
{
    [Table("RIDER")]
    public class Rider
    {
        [Key]
        [Column("RIDER_ID")]
        public int RiderId { get; set; }

        [Column("RIDER_NAME")]
        public int RiderName { get; set; }

        [Column("JOINING_DATE")]
        [DataType(DataType.Date)]
        public int JoiningDate { get; set; }

        [Column("DATE_OF_BIRTH")]
        [DataType(DataType.Date)]
        public int DateOfBirth { get; set; }

        [Column("GENDER_ID")]
        public int GENDER_ID { get; set; }

        [Column("COUNTRY_ID")]
        public int COUNTRY_ID { get; set; }

        [Column("CONTACT_NO")]
        public int ContactNo { get; set; }

        [Column("EMAIL")]
        public int Email { get; set; }

    }
}
