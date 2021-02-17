using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using VehicleTrackingSystem.Domain.Common;

namespace VehicleTrackingSystem.Domain.Entities
{
    public class VehicleLocation : AuditableEntity
    {
        [Key]
        [Column("VEHICLE_LOCATION_ID")]
        public Int64 VehicleLocationId { get; set; }

        [Column("LATITUDE")]
        public decimal Latitude { get; set; }

        [Column("LONGITUDE")]
        public decimal Longitude { get; set; }

        [Column("TRIP_DATE")]
        [DataType(DataType.Date)]
        public DateTime TripDate { get; set; }

        [Column("TRIP_TIME")]
        public String TripTime { get; set; }

        [Column("SPEED")]
        public decimal? Speed { get; set; }

        [Column("HEADING")]
        public decimal? Heading { get; set; }

        [Column("ALTITUDE")]
        public decimal? Altitude { get; set; }

        [Column("SATELLITES")]
        public short? Satellites { get; set; }

        [Column("LOCALITY")]
        public string Locality { get; set; }

        [Column("VEHICLE_ID")]
        [ForeignKey("VEHICLE_ID")]
        public Int64 VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; }


    }
}
