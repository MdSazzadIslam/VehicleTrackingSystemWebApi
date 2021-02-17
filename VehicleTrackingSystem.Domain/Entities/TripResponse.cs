using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VehicleTrackingSystem.Domain.Entities
{
    [Table("TRIP_RESPONSE")]
    public class TripResponse
    {
        [Key]
        [Column("TRIP_RESPONSE_ID")]
        public Int64 TripResponseId { get; set; }

        [ForeignKey("TRIP_REQUEST_ID")]
        public Int64 TripRequestId { get; set; }
        public TripRequest TripRequest { get; set; }

        [ForeignKey("DRIVER_ID")]
        public Int64 DriverId { get; set; }
        public virtual Driver Driver { get; set; }


    }
}
