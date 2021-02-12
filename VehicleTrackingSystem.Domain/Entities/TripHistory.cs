using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VehicleTrackingSystem.Domain.Entities
{
    [Table("VEHICLE_HISTORY")]
    public class TripHistory
    {
        [Key]
        [Column("TRIP_HISTORY_ID")]
        public int TripHistoryId { get; set; }

        //Foreign Key
        [Column("TRIP_ID")]
        public int TripId { get; set; }

        [Column("LATITUDE")]
        public decimal Latitude { get; set; }

        [Column("LONGITUDE")]
        public decimal Longitude { get; set; }

        [Column("TRIP_DATE")]
        public decimal TripDate { get; set; }

        [Column("SPEED")]
        public decimal? Speed { get; set; }

        [Column("HEADING")]
        public decimal? Heading { get; set; }

        [Column("ALTITUDE")]
        public decimal? Altitude { get; set; }

        [Column("DEVEICE_ID")]
        public decimal? DeviceId { get; set; }

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

        [ForeignKey("VEHICLE_ID")]
        public virtual VehicleInfo VehicleInfos { get; set; }
        public virtual DeviceInfo DeviceInfos { get; set; }
    }
}
