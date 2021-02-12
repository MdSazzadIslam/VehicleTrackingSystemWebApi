using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using VehicleTrackingSystem.Domain.Common;

namespace VehicleTrackingSystem.Domain.Entities
{
    [Table("TRIP_INFO")]
    public class TripInfo : AuditEntity
    {
        [Key]
        [Column("TRIP_ID")]
        public int TripId { get; set; }

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
