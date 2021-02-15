﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using VehicleTrackingSystem.Domain.Common;

namespace VehicleTrackingSystem.Domain.Entities
{
    [Table("TRIP_INFO")]
    public class TripRequest : AuditableEntity
    {
        [Key]
        [Column("TRIP_REQUEST_ID")]
        public Int64 TripRequestId { get; set; }

        [Column("START_LOCATION")]
        public int StartLocationId { get; set; }

        [Column("END_LOCATION")]
        public int EndLocationId { get; set; }

        [Column("DISTANCE")]
        public int distance { get; set; }


        //public virtual TripHistory StartLocation { get; set; }
        //public virtual TripHistory EndLocation { get; set; }

        //Foreign Key
        [Column("CUSTOMER_ID")]
        public Int64 CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        //Foreign Key
        [Column("DRIVER_ID")]
        public Int64 DriverId { get; set; }
        public virtual Driver Driver { get; set; }

        //Foreign Key
        [Column("VEHICLE_ID")]
        public Int64 VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; }

    }
}