using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace VehicleTrackingSystem.Domain.Common
{
    public class AuditableEntity
    {

        [Column("CREATE_BY")]
        public int CreatedBy { get; set; }
        [Column("CREATE_DATE")]
        public DateTime CreateDate { get; set; }
        [Column("UPDATE_BY")]
        public int UpdateBy { get; set; }
        [Column("UPDATE_DATE")]
        public DateTime UpdateDate { get; set; }
        //public string IpAddress { get; set; }

    }
}
