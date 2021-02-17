using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using VehicleTrackingSystem.Domain.Common;

namespace VehicleTrackingSystem.Domain.Entities
{
    [Table("RIDER")]
    public class Customer : AuditableEntity
    {
        [Key]
        [Column("CUSTOMER_ID")]
        public Int64 RiderId { get; set; }

        [Column("CUSTOMER_NAME")]
        public int RiderName { get; set; }

        [Column("JOINING_DATE")]
        [DataType(DataType.Date)]
        public int JoiningDate { get; set; }

        [Column("DATE_OF_BIRTH")]
        [DataType(DataType.Date)]
        public int DateOfBirth { get; set; }

        [Column("GENDER_ID")]
        public int GenderId { get; set; }

        [Column("COUNTRY_CODE")]
        public int CountryCode { get; set; }

        [Column("CONTACT_NO")]
        public int ContactNo { get; set; }

        [Column("EMAIL")]
        public int Email { get; set; }

    }
}
