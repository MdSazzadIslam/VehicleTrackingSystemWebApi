﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace VehicleTrackingSystem.Domain.Entities
{
    [Table("VEHICLE_HISTORY")]
    public class TripHistory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("TRIP_HISTORY_ID")]
        public Int64 TripHistoryId { get; set; }

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

        [Column("HDOP")]
        public decimal? HDOP { get; set; }

        [Column("POSITION_STATUS")]
        public bool? PositionStatus { get; set; }

        [Column("GSM_SIGNAL")]
        public short? GsmSignal { get; set; }

        [Column("ODO_METER")]
        public double? Odometer { get; set; }

        [Column("MOBILE_COUNTRY_CODE")]
        public int? MobileCountryCode { get; set; }

        [Column("NETWORK_COUNTRY_CODE")]
        public int? MobileNetworkCode { get; set; }

        [Column("LOCATION_AREA_CODE")]
        public int? LocationAreaCode { get; set; }

        [Column("CELL_ID")]
        public int? CellId { get; set; }

        public int? DeviceConnectionMessageId { get; set; }

        [Column("VEHICLE_ID")]
        [ForeignKey("VEHICLE_ID")]
        public Int64 VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; }

      
        [Column("TRIP_REQUEST_ID")]
        [ForeignKey("TRIP_REQUEST_ID")]
        public Int64 TripRequestId { get; set; }
        public virtual TripRequest TripRequest { get; set; }








    }
}
