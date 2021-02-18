using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VehicleTrackingSystem.Domain.Entities
{
    public class Owner
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("OWNER_ID")]
        public Int64 OwnerId { get; set; }

        [Column("OWNER_NAME")]
        public string OwnerName { get; set; }

        [Column("JOINING_DATE")]
        [DataType(DataType.Date)]
        public DateTime JoiningDate { get; set; }

        [Column("DATE_OF_BIRTH")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Column("NID_NO")]
        public int NidNo { get; set; }

        [Column("GENDER_ID")]
        public int GenderId { get; set; }

        [Column("PRESENT_ADDRESS")]
        public string PresentAddress { get; set; }

        [Column("PERMANENT_ADDRESS")]
        public string PermanentAddress { get; set; }


        [Column("COUNTRY_CODE")]
        public string CountryCode { get; set; }

        [Column("CONTACT_NO")]
        public string ContactNo { get; set; }

        [Column("EMAIL")]
        public string Email { get; set; }

        [Column("DELETED")]
        public bool Deleted { get; set; }

        //Foreign key
        [Column("VEHICLE_ID")]
        public int VehicleId { get; set; }
    }
}
