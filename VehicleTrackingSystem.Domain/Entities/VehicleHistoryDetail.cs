using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VehicleTrackingSystem.Domain.Entities
{
    [Table("VEHICLE_HISTORY_DETAIL")]
    public class VehicleHistoryDetail 
    {
        [Key]
        [Column("VEHICLE_HISTORY_DETAIL_ID")]
        public int VehicleHistoryDetailId { get; set; }

        //Foreign Key
        [Column("VEHICLE_HISTORY_ID")]
        public int VehiclehistoryId {get;set;}

        [Column("START_LOCATION")]
        public string StartLocation { get; set; }

        [Column("END_LOCATION")]
        public string EndLocation { get; set; }

        [Column("VELOCITY")]
        public Double Velocity { get; set; }

        [ForeignKey("VEHICLE_HISTORY_ID")]
        public virtual VehicleHistoryDetail VehicleHistoryDetails { get; set; }

    }
}
