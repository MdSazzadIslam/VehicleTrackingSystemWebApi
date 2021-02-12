using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace VehicleTrackingSystem.Domain.Common
{
    public class AuditableEntity
    {
        [Column("CREATE_BY")]
        public string CreatedBy { get; set; }
        [Column("CREATE_DATE")]
        public DateTime CreateDate { get; set; }
        [Column("UPDATE_BY")]
        public string UpdateBy { get; set; }
        [Column("UPDATE_DATE")]
        public DateTime UpdateDate { get; set; }

    }
}
