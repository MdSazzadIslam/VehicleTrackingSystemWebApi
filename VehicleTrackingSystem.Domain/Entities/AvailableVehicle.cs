﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VehicleTrackingSystem.Domain.Entities
{
    [Table("AVAILABLE_VEHICLE")]
    public class AvailableVehicle
    {
        [Key]
        [Column("AVAILABLE_VEHICLE_ID")]
        public Int64 AvailableVehicleId { get; set; }

        [ForeignKey("TRIP_REQUEST_ID")]
        public Int64 TripRequestId { get;set;}
        public TripRequest TripRequest { get; set; }

        [ForeignKey("DRIVER_ID")]
        public Int64 DriverId { get; set; }
        public Driver Driver { get; set; }

    }
}