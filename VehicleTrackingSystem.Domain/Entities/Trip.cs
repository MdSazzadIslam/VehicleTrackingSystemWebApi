﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using VehicleTrackingSystem.Domain.Common;

namespace VehicleTrackingSystem.Domain.Entities
{
    [Table("TRIP_INFO")]
    public class Trip : AuditableEntity
    {
        [Key]
        [Column("TRIP_ID")]
        public int TripId { get; set; }

        [Column("DRIVER_ID")]
        public int DriverId { get; set; }

        [Column("RIDER_ID")]
        public int RiderId { get; set; }

        [Column("VEHICLE_ID")]
        public int VehicleId { get; set; }

        [Column("START_LOCATION")]
        public int StartLocationId { get; set; }

        [Column("END_LOCATION")]
        public int EndLocationId { get; set; }

        [Column("DISTANCE")]
        public int distance { get; set; }

        public TripHistory StartLocation { get; set; }
        public TripHistory EndLocation { get; set; }
    }
}