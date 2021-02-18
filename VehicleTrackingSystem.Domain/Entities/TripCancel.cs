using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VehicleTrackingSystem.Domain.Entities
{
    [Table("TRIP_CANCEL")]
    public class TripCancel 
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("TRIP_CANCEL_ID")]
      
        public Int64 TripCancelId { get; set; }

        [Column("TRIP_CANCEL_DATE")]
        [DataType(DataType.Date)]
        public DateTime TripCancelDate { get; set; }

        [Column("CANCEL_REASON")]
        public Int64 TripCancelReason { get; set; }

        [Column("TRIP_CANCEL_BY")]
        public Int64 TripCancelBy { get; set; }

        //Foreign Key
        [Column("TRIP_ID")]
        public Int64 TripId { get; set; }
        public virtual TripRequest Trip { get; set; }


    }
}
